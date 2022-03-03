using System.Collections.Generic;
using System.Threading.Tasks;
using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.Contexts;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.Repositories {
    public class NewsletterQueueRepository : DbCrudRepositoryBase<NewsletterQueue>, INewsletterQueueRepository {
        public NewsletterQueueRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<NewsletterQueue>> logger) : base(dbContext, logger) {
        }

        public async Task<NewsletterQueue> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await AddToCollection(id, subscriptionItemIds, newsletterQueue => newsletterQueue.SubscriptionItems ?? new List<SubscriptionItem>());
        }

        public async Task<NewsletterQueue> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await RemoveFromCollection(id, subscriptionItemIds, newsletterQueue => newsletterQueue.SubscriptionItems ?? new List<SubscriptionItem>());
        }
    }
}
