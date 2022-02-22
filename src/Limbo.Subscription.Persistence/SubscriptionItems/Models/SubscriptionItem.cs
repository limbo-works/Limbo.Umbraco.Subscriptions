using System;
using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;

namespace Limbo.Subscriptions.Persistence.SubscriptionItems.Models {
    public class SubscriptionItem : GenericId {
        public int Id { get; set; }
        public int NodeId { get; set; }

        public virtual List<Category> Categories { get; set; }
        public virtual List<Subscriber> Subscribers { get; set; }
        public virtual List<NewsletterQueue> NewsletterQueues { get; set; }

        public static void Validate(SubscriptionItem subscriptionItem, bool checkRelations = true) {
            if (subscriptionItem == null) {
                throw new ArgumentException("SubscriptionItem cannot be null", nameof(subscriptionItem));
            }

            if (checkRelations) {
                subscriptionItem.Categories?.ForEach(category => Category.Vaildate(category, false));
                subscriptionItem.Subscribers?.ForEach(subscriber => Subscriber.Validate(subscriber, false));
                subscriptionItem.NewsletterQueues?.ForEach(newsletterQueue => NewsletterQueue.Validate(newsletterQueue, false));
            }
        }
    }
}
