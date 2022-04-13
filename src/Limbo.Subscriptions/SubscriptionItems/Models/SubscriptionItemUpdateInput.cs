using System.ComponentModel.DataAnnotations;

namespace Limbo.Subscriptions.SubscriptionItems.Models {
    /// <summary>
    /// Model for updating a subscription item
    /// </summary>
    public class SubscriptionItemUpdateInput {
        /// <summary>
        /// Id
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Subscription item node id
        /// </summary>
        [Required]
        public int NodeId { get; set; }
    }
}