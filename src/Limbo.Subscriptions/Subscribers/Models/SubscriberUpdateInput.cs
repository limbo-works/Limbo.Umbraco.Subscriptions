using System;
using System.ComponentModel.DataAnnotations;

namespace Limbo.Subscriptions.Subscribers.Models {
    /// <summary>
    /// Model for updating a subscriber
    /// </summary>
    public class SubscriberUpdateInput {

        /// <summary>
        /// Id
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// The subscriber name
        /// </summary>
        [Required]
        public string? Name { get; set; }

        /// <summary>
        /// The email of the subscriber
        /// </summary>
        [Required]
        public string? Email { get; set; }

        /// <summary>
        /// Is the subscriber confirmed
        /// </summary>
        [Required]
        public bool IsConfirmed { get; set; }

        /// <summary>
        /// When was the subscriber created
        /// </summary>
        [Required]
        public DateTime Created { get; set; }

        /// <summary>
        /// The id of the subscription system
        /// </summary>
        [Required]
        public virtual int SubscriptionSystemId { get; set; }
    }
}
