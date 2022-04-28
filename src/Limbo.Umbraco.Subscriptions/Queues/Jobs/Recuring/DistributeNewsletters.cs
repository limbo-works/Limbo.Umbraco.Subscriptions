using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Limbo.MailSystem.Distribution.Services;
using Limbo.MailSystem.Mails.Models;
using Limbo.MailSystem.Receivers.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Subscribers.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Infrastructure.HostedServices;
using Limbo.MailSystem.Templates.RazorTemplates.Builders;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using System;
using Limbo.Subscriptions.NewsletterQueues.Services;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Umbraco.Subscriptions.Queues.Jobs.Recuring.Models;
using Limbo.Subscriptions.Subscribers.Models;

namespace Limbo.Umbraco.Subscriptions.Queues.Jobs.Recuring {
    internal class DistributeNewsletters : RecurringHostedServiceBase {
        private readonly IRuntimeState _runtimeState;
        private readonly ILogger<DistributeNewsletters> _logger;
        private readonly IEmailDistributorService _emailDistributorService;
        private readonly IRazorBuilder _razorBuilder;
        private readonly ISubscriberService _subscriberService;
        private readonly DistributeNewsLettersSettings _distributeNewsLettersSettings;
        private readonly INewsletterQueueService _newsletterQueueService;
        private DateTime _lastSend = default;
        private readonly object _lastSendLock = new();

        public DistributeNewsletters(ILogger<DistributeNewsletters> logger, IRuntimeState runtimeState, IEmailDistributorService emailDistributorService, ISubscriberService subscriberService, IRazorBuilder razorBuilder, DistributeNewsLettersSettings distributeNewsLettersSettings, INewsletterQueueService newsletterQueueService) : base(distributeNewsLettersSettings.HowOftenWeRepeat, distributeNewsLettersSettings.DelayBeforeWeStart) {
            _logger = logger;
            _runtimeState = runtimeState;
            _emailDistributorService = emailDistributorService;
            _subscriberService = subscriberService;
            _razorBuilder = razorBuilder;
            _distributeNewsLettersSettings = distributeNewsLettersSettings;
            _newsletterQueueService = newsletterQueueService;
        }

        public override async Task PerformExecuteAsync(object state) {
            try {
                if (_runtimeState.Level != RuntimeLevel.Run) {
                    return;
                }

                lock (_lastSendLock) {
                    if (!IsDistributionAllowed()) {
                        return;
                    }

                    _lastSend = DateTime.UtcNow;
                }


                _logger.LogInformation("Running DistributeNewsletters");

                int page = 0;
                IEnumerable<Mail>? mails;

                do {
                    mails = await GetMails(page);

                    if (mails.Any()) {
                        _emailDistributorService.QueueDistributeEmails(mails.ToList(), _distributeNewsLettersSettings.SendMailMethod);

                        page++;
                    }
                } while (mails.Any());

                _logger.LogInformation("Clearing newsletter queue");
                await ClearQueue(QueueConstants.DefaultQueueName);
                _logger.LogInformation("Done clearing newsletter queue");
            } catch (Exception ex) {
                _logger.LogError(ex, "Failed to distribute newsletters");
            }
            return;
        }

        public bool IsDistributionAllowed() {
            if (_distributeNewsLettersSettings.HowOftenToSend != null) {
                if (_lastSend.Add(_distributeNewsLettersSettings.HowOftenToSend.Value).ToUniversalTime() > DateTime.UtcNow) {
                    return false;
                }
            } else if (_distributeNewsLettersSettings.AllowedStartTime != null && _distributeNewsLettersSettings.StopTime != null) {
                if (!IsAllowedTimeofDay()) {
                    return false;
                }
            }
            return true;

            bool IsAllowedTimeofDay() {
                return DateTime.UtcNow.TimeOfDay > _distributeNewsLettersSettings.AllowedStartTime.Value.ToUniversalTime().TimeOfDay &&
                    DateTime.UtcNow.TimeOfDay < _distributeNewsLettersSettings.StopTime.Value.ToUniversalTime().TimeOfDay;
            }
        }

        private async Task ClearQueue(string queueName) {
            var newsletterQueue = (await _newsletterQueueService.QueryDbSet()).ResponseValue?.Select(queue => new NewsletterQueue {
                Id = queue.Id,
                Name = queue.Name,
            }).FirstOrDefault(queue => queue.Name == queueName);
            if (newsletterQueue != null) {
                await ClearQueue(newsletterQueue.Id);
            } else {
                _logger.LogError("Failed to find queue");
            }
        }

        private async Task ClearQueue(int queueId) {
            var subscriptionItems = (await _newsletterQueueService.QueryDbSet()).ResponseValue.Include(item => item.SubscriptionItems).Select(queue => new NewsletterQueue {
                SubscriptionItems = queue.SubscriptionItems
            }).ToList().SelectMany(queue => queue.SubscriptionItems ?? new List<SubscriptionItem>());
            var subscriptionItemIds = subscriptionItems.Select(item => item.Id).ToArray();
            _logger.LogDebug("subscriptionItemIds Count {Count}", subscriptionItemIds.Length);
            if (subscriptionItemIds.Any()) {
                await _newsletterQueueService.RemoveSubscriptionItems(queueId, subscriptionItemIds);
            }
        }

        private async Task<IEnumerable<Mail>> GetMails(int page) {
            var subscribers = await GetSubscribers(page);
            var mails = new List<Mail>();

            foreach (var subscriber in subscribers) {
                if (!ShouldSendMail(subscriber)) {
                    continue;
                }

                var receivers = new List<Recipient> {
                    new Recipient { Email = subscriber.Email, Name = subscriber.Name }
                };

                var subscriberInformation = new SubscriberTemplateModel(subscriber);

                var mail = await _razorBuilder.BuildMail(receivers, _distributeNewsLettersSettings.SubjectTitle, _distributeNewsLettersSettings.TemplatePath, subscriberInformation);

                mails.Add(mail);
            }

            return mails;
        }

        private bool ShouldSendMail(Subscriber subscriber) {
            var subscriptionItems = subscriber.SubscriptionItems;

            if (subscriptionItems != null && subscriptionItems.Any() && subscriptionItems.Any(item => item.NewsletterQueues != null && item.NewsletterQueues.Any(queue => queue.Name == _distributeNewsLettersSettings.QueueName))) {
                return true;
            }

            var categorySubscriptionItems = subscriber.Categories?.SelectMany(category => category.SubscriptionItems ?? new List<SubscriptionItem> { new SubscriptionItem { Id = -1 } }).Where(item => item.Id != -1);

            if (categorySubscriptionItems != null && categorySubscriptionItems.Any() && categorySubscriptionItems.Any(item => item.NewsletterQueues != null && item.NewsletterQueues.Any(queue => queue.Name == _distributeNewsLettersSettings.QueueName))) {
                return true;
            }

            return false;
        }

        private async Task<List<Subscriber>> GetSubscribers(int page) {
            return (await _subscriberService.QueryDbSet()).ResponseValue
                .Include(item => item.SubscriptionItems)
                .ThenInclude(item => item.NewsletterQueues)
                .Include(item => item.Categories)
                .OrderBy(item => item.Id)
                .Skip(_distributeNewsLettersSettings.PageSize * page)
                .Take(_distributeNewsLettersSettings.PageSize)
                .ToList(); // Here the subscribers is queried from the database
        }
    }
}
