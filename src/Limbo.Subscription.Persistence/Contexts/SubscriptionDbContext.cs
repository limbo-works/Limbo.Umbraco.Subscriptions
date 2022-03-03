using System.Reflection;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Microsoft.EntityFrameworkCore;

namespace Limbo.Subscriptions.Persistence.Contexts {
    /// <inheritdoc/>
    public class SubscriptionDbContext : DbContext, ISubscriptionDbContext {

        /// <inheritdoc/>
        public SubscriptionDbContext(DbContextOptions<SubscriptionDbContext> options) : base(options) {
        }

        //TODO Remove this disable when updating EF Core
#pragma warning disable CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).

        /// <inheritdoc/>
        public DbSet<Category>? Categories { get; set; }

        /// <inheritdoc/>
        public DbSet<NewsletterQueue>? NewsletterQueues { get; set; }

        /// <inheritdoc/>
        public DbSet<Subscriber>? Subscribers { get; set; }

        /// <inheritdoc/>
        public DbSet<SubscriptionItem>? SubscriptionItems { get; set; }

        /// <inheritdoc/>
        public DbSet<SubscriptionSystem>? SubscriptionSystems { get; set; }
#pragma warning restore CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).

        /// <inheritdoc/>
        public DbContext Context => this;

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
