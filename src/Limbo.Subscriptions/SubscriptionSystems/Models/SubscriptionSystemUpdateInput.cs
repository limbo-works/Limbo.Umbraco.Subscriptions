using System.ComponentModel.DataAnnotations;

namespace Limbo.Subscriptions.SubscriptionSystems.Models {
    /// <summary>
    /// Model for updating a subscription system
    /// </summary>
    public class SubscriptionSystemUpdateInput {
        /// <summary>
        /// Id
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Subscription system name
        /// </summary>
        [Required]
        public string? Name { get; set; }
    }
}