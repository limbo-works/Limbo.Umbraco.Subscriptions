using System.Collections.Generic;
using System.Threading.Tasks;
using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.Contexts;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.Persistence.Subscribers.Repositories {
    public class SubscriberRepository : DbCrudRepositoryBase<Subscriber>, ISubscriberRepository {
        public SubscriberRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<Subscriber>> logger) : base(dbContext, logger) {
        }

        public async Task<Subscriber> AddCategories(int id, int[] categoryIds) {
            return await AddToCollection(id, categoryIds, subscriber => subscriber.Categories ?? new List<Category>());
        }

        public async Task<Subscriber> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await AddToCollection(id, subscriptionItemIds, subscriber => subscriber.SubscriptionItems ?? new List<SubscriptionItem>());
        }

        public async Task<Subscriber> RemoveCategories(int id, int[] categoryIds) {
            return await RemoveFromCollection(id, categoryIds, subscriber => subscriber.Categories ?? new List<Category>());
        }

        public async Task<Subscriber> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await RemoveFromCollection(id, subscriptionItemIds, subscriber => subscriber.SubscriptionItems ?? new List<SubscriptionItem>());
        }
    }
}
