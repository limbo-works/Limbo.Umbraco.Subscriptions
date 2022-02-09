using System;
using System.Collections.Generic;
using Limbo.Umbraco.Subscription.Persistence.Bases.Model;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models;

namespace Limbo.Umbraco.Subscription.Persistence.Subscribers.Models {
    public class Subscriber : GenericId {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime Created { get; set; }

        public virtual List<SubscriptionItem> SubscriptionItems { get; set; }
        public virtual SubscriptionSystem SubscriptionSystem { get; set; }
        public virtual List<Category> Categories { get; set; }
    }
}
