using System;
using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.Models {
    public class SubscriptionSystem : GenericId {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual List<Subscriber>? Subscribers { get; set; }

        public static void Validate(SubscriptionSystem? subscriptionSystem, bool checkRelations = true) {
            if (subscriptionSystem == null) {
                throw new ArgumentException("SubscriptionSystem cannot be null", nameof(subscriptionSystem));
            }

            if (checkRelations) {
                subscriptionSystem.Subscribers?.ForEach(subscriber => Subscriber.Validate(subscriber, false));
            }
        }
    }
}
