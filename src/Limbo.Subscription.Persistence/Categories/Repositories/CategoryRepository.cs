using System.Collections.Generic;
using System.Threading.Tasks;
using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.Contexts;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.Persistence.Categories.Repositories {
    public class CategoryRepository : DbCrudRepositoryBase<Category>, ICategoryRepository {
        public CategoryRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<Category>> logger) : base(dbContext, logger) {
        }

        public async Task<Category> AddSubscribers(int id, int[] subscriberIds) {
            return await AddToCollection(id, subscriberIds, category => category.Subscribers ?? new List<Subscriber>());
        }

        public async Task<Category> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await AddToCollection(id, subscriptionItemIds, category => category.SubscriptionItems ?? new List<SubscriptionItem>());
        }

        public async Task<Category> RemoveSubscribers(int id, int[] subscriberIds) {
            return await RemoveFromCollection(id, subscriberIds, category => category.Subscribers ?? new List<Subscriber>());
        }

        public async Task<Category> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await RemoveFromCollection(id, subscriptionItemIds, category => category.SubscriptionItems ?? new List<SubscriptionItem>());
        }
    }
}
