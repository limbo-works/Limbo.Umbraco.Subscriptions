using Limbo.DataAccess.Contexts.Models;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Microsoft.EntityFrameworkCore;

namespace Limbo.Subscriptions.Persistence.Contexts {
    public interface ISubscriptionDbContext : IDbContext {
        DbSet<Category> Categories { get; set; }
        DbSet<NewsletterQueue> NewsletterQueues { get; set; }
        DbSet<Subscriber> Subscribers { get; set; }
        DbSet<SubscriptionItem> SubscriptionItems { get; set; }
        DbSet<SubscriptionSystem> SubscriptionSystems { get; set; }
    }
}