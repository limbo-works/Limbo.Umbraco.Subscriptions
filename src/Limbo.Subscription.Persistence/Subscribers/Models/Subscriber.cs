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

        public static void Validate(Subscriber subscriber, bool checkRelations = true) {
            if (subscriber == null) {
                throw new ArgumentException("Subscriber cannot be null", nameof(subscriber));
            }

            if (subscriber.Name == null) {
                throw new ArgumentException("Name cannot be null", nameof(subscriber));
            }

            if (subscriber.Email == null) {
                throw new ArgumentException("Email cannot be null", nameof(subscriber));
            }

            if (checkRelations) {
                subscriber.SubscriptionItems?.ForEach(subscriptionItem => SubscriptionItem.Validate(subscriptionItem, false));
                SubscriptionSystem.Validate(subscriber?.SubscriptionSystem, false);
                subscriber.Categories?.ForEach(category => Category.Vaildate(category, false));
            }
        }
    }
}
