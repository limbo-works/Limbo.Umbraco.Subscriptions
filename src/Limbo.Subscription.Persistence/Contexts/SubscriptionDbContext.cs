﻿using System.Reflection;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Microsoft.EntityFrameworkCore;

namespace Limbo.Subscriptions.Persistence.Contexts {
    public class SubscriptionDbContext : DbContext, ISubscriptionDbContext {

        public SubscriptionDbContext(DbContextOptions<SubscriptionDbContext> options) : base(options) {
            Database.Migrate();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<NewsletterQueue> NewsletterQueues { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<SubscriptionItem> SubscriptionItems { get; set; }
        public DbSet<SubscriptionSystem> SubscriptionSystems { get; set; }

        public DbContext Context => this;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}