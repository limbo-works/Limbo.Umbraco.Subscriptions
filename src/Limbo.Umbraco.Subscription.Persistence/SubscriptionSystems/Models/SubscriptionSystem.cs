using System.Collections.Generic;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models {
    public class SubscriptionSystem {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Subscriber> Subscribers { get; set; }
    }
}
