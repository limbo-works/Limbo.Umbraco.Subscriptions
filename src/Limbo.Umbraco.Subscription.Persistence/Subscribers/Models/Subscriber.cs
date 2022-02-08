using System;
using System.Collections.Generic;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models;

namespace Limbo.Umbraco.Subscription.Persistence.Subscribers.Models {
    public class Subscriber {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime Created { get; set; }

        public IEnumerable<SubscriptionItem> SubscriptionItems { get; set; }
        public SubscriptionSystem SubscriptionSystem { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public byte[] ConcurrencyStamp { get; set; }
    }
}
