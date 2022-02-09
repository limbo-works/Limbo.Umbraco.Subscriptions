using System.Collections.Generic;
using Limbo.Umbraco.Subscription.Persistence.Bases.Model;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models {
    public class SubscriptionSystem : GenericId {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Subscriber> Subscribers { get; set; }
    }
}
