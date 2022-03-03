using System;
using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;

namespace Limbo.Subscriptions.Persistence.SubscriptionItems.Models {
    /// <summary>
    /// Represents a subscription item
    /// </summary>
    public class SubscriptionItem : GenericId {
        /// <summary>
        /// The unique id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The node id of the item
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// The categories og the subscription item
        /// </summary>
        public virtual List<Category>? Categories { get; set; }

        /// <summary>
        /// The subscribers of the subscription item
        /// </summary>
        public virtual List<Subscriber>? Subscribers { get; set; }

        /// <summary>
        /// The newsletterqueues of the subscription item
        /// </summary>
        public virtual List<NewsletterQueue>? NewsletterQueues { get; set; }

        /// <summary>
        /// Validates if a subscription item is valid
        /// </summary>
        /// <param name="subscriptionItem"></param>
        /// <param name="checkRelations"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void Validate(SubscriptionItem? subscriptionItem, bool checkRelations = true) {
            if (subscriptionItem == null) {
                throw new ArgumentException("SubscriptionItem cannot be null", nameof(subscriptionItem));
            }

            if (checkRelations) {
                subscriptionItem.Categories?.ForEach(category => Category.Vaildate(category, false));
                subscriptionItem.Subscribers?.ForEach(subscriber => Subscriber.Validate(subscriber, false));
                subscriptionItem.NewsletterQueues?.ForEach(newsletterQueue => NewsletterQueue.Validate(newsletterQueue, false));
            }
        }
    }
}
