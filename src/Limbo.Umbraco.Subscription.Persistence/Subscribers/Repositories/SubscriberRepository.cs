﻿using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscription.Persistence.Subscribers.Repositories {
    public class SubscriberRepository : DbCrudRepositoryBase<Subscriber>, ISubscriberRepository {
        public SubscriberRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<Subscriber>> logger) : base(dbContext, logger) {
        }

        public async Task<Subscriber> AddCategories(int id, int[] categoryIds) {
            return await AddToCollection(id, categoryIds, subscriber => subscriber.Categories);
        }

        public async Task<Subscriber> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await AddToCollection(id, subscriptionItemIds, subscriber => subscriber.SubscriptionItems);
        }

        public async Task<Subscriber> RemoveCategories(int id, int[] categoryIds) {
            return await RemoveFromCollection(id, categoryIds, subscriber => subscriber.Categories);
        }

        public async Task<Subscriber> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await RemoveFromCollection(id, subscriptionItemIds, subscriber => subscriber.SubscriptionItems);
        }
    }
}
