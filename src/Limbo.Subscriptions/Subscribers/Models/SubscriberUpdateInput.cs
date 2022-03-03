using System;
using System.ComponentModel.DataAnnotations;

namespace Limbo.Subscriptions.Subscribers.Models {
    public class SubscriberUpdateInput {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public bool IsConfirmed { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public virtual int SubscriptionSystemId { get; set; }
    }
}
