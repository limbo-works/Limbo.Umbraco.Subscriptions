using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Limbo.Subscriptions.NewsletterQueues.Services;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.SubscriptionItems.Services;
using Limbo.Umbraco.Subscriptions.Properties;
using Limbo.Umbraco.Subscriptions.Queues;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Notifications;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Saving {
    internal class ContentSavingNotificationHandler : INotificationAsyncHandler<ContentSavingNotification> {
        private readonly ISubscriptionItemService _subscriptionItemService;
        private readonly INewsletterQueueService _newsletterQueueService;
        private readonly ILogger<ContentSavingNotificationHandler> _logger;

        public ContentSavingNotificationHandler(ISubscriptionItemService subscriptionItemService, ILogger<ContentSavingNotificationHandler> logger, INewsletterQueueService newsletterQueueService) {
            _subscriptionItemService = subscriptionItemService;
            _logger = logger;
            _newsletterQueueService = newsletterQueueService;
        }

        public async Task HandleAsync(ContentSavingNotification notification, CancellationToken cancellationToken) {
            foreach (var contentItem in notification.SavedEntities) {
                if (contentItem.HasProperty(PropertyAliases.IncludeInNextNewsletterAlias)) {
                    var includeInNextNewsletterRaw = contentItem.GetValue(PropertyAliases.IncludeInNextNewsletterAlias);
                    bool IsNew = contentItem.HasIdentity is false;
                    if (IsNew && includeInNextNewsletterRaw == null) {
                        await AddToNewsLetter(contentItem);
                    } else if ((int) includeInNextNewsletterRaw == 1) {
                        await AddToNewsLetter(contentItem);
                    } else {
                        await RemoveFromNewsletter(contentItem);
                    }
                }
            }
        }

        private async Task RemoveFromNewsletter(IContent contentItem) {
            var exsitingItem = (await _subscriptionItemService.QueryDbSet()).ReponseValue?.Include(item => item.NewsletterQueues).FirstOrDefault(item => item.NodeId == contentItem.Id);
            if (exsitingItem == null) {
                exsitingItem = (await _subscriptionItemService.Add(new() { NodeId = contentItem.Id })).ReponseValue;
            }
            if (exsitingItem != null && exsitingItem.NewsletterQueues != null && exsitingItem.NewsletterQueues.Any(item => item.Name == QueueConstants.DefaultQueueName)) {
                var newsletter = exsitingItem.NewsletterQueues.First(item => item.Name == QueueConstants.DefaultQueueName);
                await _subscriptionItemService.RemoveNewsletterQueues(exsitingItem.Id, new[] { newsletter.Id });
            } else {
                _logger.LogError($"Failed to remove content item to newsletter: {contentItem.Id} - {contentItem.Name}");
            }
        }

        private async Task AddToNewsLetter(IContent contentItem) {
            var exsitingItem = (await _subscriptionItemService.QueryDbSet()).ReponseValue?.FirstOrDefault(item => item.NodeId == contentItem.Id);
            if (exsitingItem == null) {
                exsitingItem = (await _subscriptionItemService.Add(new() { NodeId = contentItem.Id })).ReponseValue;
            }
            if (exsitingItem != null) {
                NewsletterQueue? newsletter = await GetNewsletter();
                if (newsletter != null) {
                    await _subscriptionItemService.AddNewsletterQueues(exsitingItem.Id, new[] { newsletter.Id });
                } else {
                    _logger.LogError("Failed to find newsletter");
                }
            } else {
                _logger.LogError($"Failed to add content item to newsletter: {contentItem.Id} - {contentItem.Name}");
            }
        }

        private async Task<NewsletterQueue?> GetNewsletter() {
            var newsletter = (await _newsletterQueueService.QueryDbSet()).ReponseValue?.FirstOrDefault(item => item.Name == QueueConstants.DefaultQueueName);
            if (newsletter == null) {
                newsletter = (await _newsletterQueueService.Add(new NewsletterQueue { Name = QueueConstants.DefaultQueueName })).ReponseValue;
            }

            return newsletter;
        }
    }
}
