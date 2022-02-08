using System.Reflection;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models;
using Microsoft.EntityFrameworkCore;

namespace Limbo.Umbraco.Subscription.Persistence.Contexts {
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
