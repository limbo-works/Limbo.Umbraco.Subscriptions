using System.Linq;
using System.Threading.Tasks;
using Limbo.Subscriptions.NewsletterQueues.Services;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.SubscriptionItems.Services;
using Limbo.Umbraco.Subscriptions.Queues;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Models;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Managers {
    /// <inheritdoc/>
    public class ContentNewsletterManager : IContentNewsletterManager {
        private readonly ISubscriptionItemService _subscriptionItemService;
        private readonly INewsletterQueueService _newsletterQueueService;
        private readonly ILogger<ContentNewsletterManager> _logger;

        /// <inheritdoc/>
        public ContentNewsletterManager(ISubscriptionItemService subscriptionItemService, ILogger<ContentNewsletterManager> logger, INewsletterQueueService newsletterQueueService) {
            _subscriptionItemService = subscriptionItemService;
            _logger = logger;
            _newsletterQueueService = newsletterQueueService;
        }

        /// <inheritdoc/>
        public async Task AddToNewsLetter(IContent contentItem) {
            var exsitingItem = (await _subscriptionItemService.QueryDbSet()).ResponseValue?.FirstOrDefault(item => item.NodeId == contentItem.Id);
            if (exsitingItem == null) {
                exsitingItem = (await _subscriptionItemService.Add(new() { NodeId = contentItem.Id })).ResponseValue;
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

        /// <inheritdoc/>
        public async Task RemoveFromNewsletter(IContent contentItem) {
            var exsitingItem = (await _subscriptionItemService.QueryDbSet()).ResponseValue?.Include(item => item.NewsletterQueues).FirstOrDefault(item => item.NodeId == contentItem.Id);
            if (exsitingItem == null) {
                exsitingItem = (await _subscriptionItemService.Add(new() { NodeId = contentItem.Id })).ResponseValue;
            }
            if (exsitingItem != null && exsitingItem.NewsletterQueues != null && exsitingItem.NewsletterQueues.Any(item => item.Name == QueueConstants.DefaultQueueName)) {
                var newsletter = exsitingItem.NewsletterQueues.First(item => item.Name == QueueConstants.DefaultQueueName);
                await _subscriptionItemService.RemoveNewsletterQueues(exsitingItem.Id, new[] { newsletter.Id });
            } else {
                _logger.LogError($"Failed to remove content item to newsletter: {contentItem.Id} - {contentItem.Name}");
            }
        }

        /// <summary>
        /// Gets the newsletter
        /// </summary>
        /// <returns></returns>
        private async Task<NewsletterQueue?> GetNewsletter() {
            var newsletter = (await _newsletterQueueService.QueryDbSet()).ResponseValue?.FirstOrDefault(item => item.Name == QueueConstants.DefaultQueueName);
            if (newsletter == null) {
                newsletter = (await _newsletterQueueService.Add(new NewsletterQueue { Name = QueueConstants.DefaultQueueName })).ResponseValue;
            }

            return newsletter;
        }
    }
}
