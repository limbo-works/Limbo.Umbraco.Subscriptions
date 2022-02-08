using System.Collections.Generic;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models {
    public class SubscriptionItem {
        public int Id { get; set; }
        public int NodeId { get; set; }

        public virtual IEnumerable<Category> Categories { get; set; }
        public virtual IEnumerable<Subscriber> Subscribers { get; set; }
        public virtual IEnumerable<NewsletterQueue> NewsletterQueues { get; set; }

        public byte[] ConcurrencyStamp { get; set; }
    }
}
