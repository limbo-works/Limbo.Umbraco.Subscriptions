using System;
using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.Models {
    public class NewsletterQueue : GenericId {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<SubscriptionItem> SubscriptionItems { get; set; }

        public static void Validate(NewsletterQueue newsletterQueue, bool checkRelations = true) {
            if (newsletterQueue == null) {
                throw new ArgumentException("NewsletterQueue cannot be null", nameof(newsletterQueue));
            }

            if (newsletterQueue.Name == null) {
                throw new ArgumentException("Name cannot be null", nameof(newsletterQueue));
            }

            if (checkRelations) {
                newsletterQueue.SubscriptionItems?.ForEach(subscriptionItem => SubscriptionItem.Validate(subscriptionItem, false));
            }
        }
    }
}
