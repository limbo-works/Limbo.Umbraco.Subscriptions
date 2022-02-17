using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;

namespace Limbo.Subscriptions.Persistence.Categories.Models {
    public class Category : GenericId {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Subscriber> Subscribers { get; set; }
        public virtual List<SubscriptionItem> SubscriptionItems { get; set; }
    }
}
