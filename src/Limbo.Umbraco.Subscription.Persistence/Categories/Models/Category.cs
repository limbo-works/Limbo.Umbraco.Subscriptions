using System.Collections.Generic;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;

namespace Limbo.Umbraco.Subscription.Persistence.Categories.Models {
    public class Category {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Subscriber> Subscribers { get; set; }
        public IEnumerable<SubscriptionItem> SubscriptionItems { get; set; }
    }
}
