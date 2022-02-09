﻿using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscription.Persistence.Categories.Repositories {
    public class CategoryRepository : DbCrudRepositoryBase<Category>, ICategoryRepository {
        public CategoryRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<Category>> logger) : base(dbContext, logger) {
        }

        public async Task<Category> AddSubscribers(int id, int[] subscriberIds) {
            return await AddToCollection(id, subscriberIds, category => category.Subscribers);
        }

        public async Task<Category> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await AddToCollection(id, subscriptionItemIds, category => category.SubscriptionItems);
        }

        public async Task<Category> RemoveSubscribers(int id, int[] subscriberIds) {
            return await RemoveFromCollection(id, subscriberIds, category => category.Subscribers);
        }

        public async Task<Category> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await RemoveFromCollection(id, subscriptionItemIds, category => category.SubscriptionItems);
        }
    }
}
