using System;
using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;

namespace Limbo.Subscriptions.Persistence.Subscribers.Models {
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
