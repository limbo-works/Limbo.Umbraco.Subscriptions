using System.Collections.Generic;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;

namespace Limbo.Umbraco.Subscription.Persistence.Categories.Models {
    public class Category {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Subscriber> Subscribers { get; set; }
        public virtual IEnumerable<SubscriptionItem> SubscriptionItems { get; set; }

        public byte[] ConcurrencyStamp { get; set; }
    }
}
