﻿using System.Reflection;
using System.Threading.Tasks;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Microsoft.EntityFrameworkCore;

namespace Limbo.Subscriptions.Persistence.Contexts {
    /// <inheritdoc/>
    public class SubscriptionDbContext : DbContext, ISubscriptionDbContext {
        private static readonly string _tablePrefix = "Limbo_Subscription";

        /// <inheritdoc/>
        public SubscriptionDbContext(DbContextOptions<SubscriptionDbContext> options) : base(options) {
        }


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

        /// <inheritdoc/>
        public DbContext Context => this;

        public override void Dispose() {
            base.Dispose();
        }

        public override ValueTask DisposeAsync() {
            return base.DisposeAsync();
        }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Prefix tables
            foreach (var entityType in modelBuilder.Model.GetEntityTypes()) {
                entityType.SetTableName(_tablePrefix + "_" + entityType.GetTableName());
            }
        }
    }
}
