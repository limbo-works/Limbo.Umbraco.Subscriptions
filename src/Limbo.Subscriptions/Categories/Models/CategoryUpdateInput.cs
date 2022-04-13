using System.ComponentModel.DataAnnotations;

namespace Limbo.Subscriptions.Categories.Models {
    /// <summary>
    /// Model for updating a category
    /// </summary>
    public class CategoryUpdateInput {
        /// <summary>
        /// Id
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// The name of the category
        /// </summary>
        [Required]
        public string? Name { get; set; }
    }
}