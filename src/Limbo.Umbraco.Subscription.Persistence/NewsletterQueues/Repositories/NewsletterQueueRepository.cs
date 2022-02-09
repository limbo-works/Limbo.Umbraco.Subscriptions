using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Repositories {
    public class NewsletterQueueRepository : DbCrudRepositoryBase<NewsletterQueue>, INewsletterQueueRepository {
        public NewsletterQueueRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<NewsletterQueue>> logger) : base(dbContext, logger) {
        }

        public async Task<NewsletterQueue> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await AddToCollection(id, subscriptionItemIds, newsletterQueue => newsletterQueue.SubscriptionItems);
        }

        public async Task<NewsletterQueue> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await RemoveFromCollection(id, subscriptionItemIds, newsletterQueue => newsletterQueue.SubscriptionItems);
        }
    }
}
