using System.Collections.Generic;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models {
    public class SubscriptionItem {
        public int Id { get; set; }
        public int NodeId { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Subscriber> Subscribers { get; set; }
        public IEnumerable<NewsletterQueue> NewsletterQueues { get; set; }
    }
}
