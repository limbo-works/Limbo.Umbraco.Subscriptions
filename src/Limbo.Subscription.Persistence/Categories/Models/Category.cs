using System;
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

        public static void Vaildate(Category category, bool checkReleations = true) {
            if (category == null) {
                throw new ArgumentException("Category cannot be null", nameof(category));
            }

            if (category.Name == null) {
                throw new ArgumentException("Name cannot be null", nameof(category));
            }

            if (checkReleations) {
                category.Subscribers?.ForEach(subscriber => Subscriber.Validate(subscriber, false));
                category.SubscriptionItems?.ForEach(subscriptionItem => SubscriptionItem.Validate(subscriptionItem, false));
            }
        }
    }
}
