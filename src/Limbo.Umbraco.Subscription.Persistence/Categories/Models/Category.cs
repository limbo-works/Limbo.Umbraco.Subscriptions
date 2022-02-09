using System.Collections.Generic;
using Limbo.Umbraco.Subscription.Persistence.Bases.Model;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;

namespace Limbo.Umbraco.Subscription.Persistence.Categories.Models {
    public class Category : GenericId {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Subscriber> Subscribers { get; set; }
        public virtual List<SubscriptionItem> SubscriptionItems { get; set; }
    }
}
