using System.Collections.Generic;
using Limbo.Umbraco.Subscription.Persistence.Bases.Model;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;

namespace Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models {
    public class NewsletterQueue : GenericId {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<SubscriptionItem> SubscriptionItems { get; set; }
    }
}
