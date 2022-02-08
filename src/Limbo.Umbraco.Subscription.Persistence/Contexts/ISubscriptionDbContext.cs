using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models;
using Microsoft.EntityFrameworkCore;

namespace Limbo.Umbraco.Subscription.Persistence.Contexts {
    public interface ISubscriptionDbContext : IDbContext {
        DbSet<Category> Categories { get; set; }
        DbSet<NewsletterQueue> NewsletterQueues { get; set; }
        DbSet<Subscriber> Subscribers { get; set; }
        DbSet<SubscriptionItem> SubscriptionItems { get; set; }
        DbSet<SubscriptionSystem> SubscriptionSystems { get; set; }
    }
}