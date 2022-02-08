using System.Collections.Generic;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;

namespace Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models {
    public class NewsletterQueue {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<SubscriptionItem> SubscriptionItems { get; set; }
    }
}
