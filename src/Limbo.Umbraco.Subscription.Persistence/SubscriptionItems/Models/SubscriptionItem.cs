using System.Collections.Generic;
using Limbo.Umbraco.Subscription.Persistence.Bases.Model;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models {
    public class SubscriptionItem : GenericId {
        public int Id { get; set; }
        public int NodeId { get; set; }

        public virtual List<Category> Categories { get; set; }
        public virtual List<Subscriber> Subscribers { get; set; }
        public virtual List<NewsletterQueue> NewsletterQueues { get; set; }
    }
}
