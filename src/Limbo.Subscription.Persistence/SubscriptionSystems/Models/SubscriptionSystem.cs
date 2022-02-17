using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.Models {
    public class SubscriptionSystem : GenericId {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Subscriber> Subscribers { get; set; }
    }
}
