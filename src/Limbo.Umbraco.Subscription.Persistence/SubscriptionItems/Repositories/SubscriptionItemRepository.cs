using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Repositories {
    public class SubscriptionItemRepository : DbCrudRepositoryBase<SubscriptionItem>, ISubscriptionItemRepository {
        public SubscriptionItemRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<SubscriptionItem>> logger) : base(dbContext, logger) {
        }

        public async Task<SubscriptionItem> AddCategories(int id, int[] categoryIds) {
            return await AddToCollection(id, categoryIds, subscriptionItem => subscriptionItem.Categories);
        }

        public async Task<SubscriptionItem> AddNewsletterQueues(int id, int[] newsletterQueueIds) {
            return await AddToCollection(id, newsletterQueueIds, subscriptionItem => subscriptionItem.NewsletterQueues);
        }

        public async Task<SubscriptionItem> AddSubscribers(int id, int[] subscriberIds) {
            return await AddToCollection(id, subscriberIds, subscriptionItem => subscriptionItem.Subscribers);
        }

        public async Task<SubscriptionItem> RemoveCategories(int id, int[] categoryIds) {
            return await RemoveFromCollection(id, categoryIds, subscriptionItem => subscriptionItem.Categories);
        }

        public async Task<SubscriptionItem> RemoveNewsletterQueues(int id, int[] newsletterQueueIds) {
            return await RemoveFromCollection(id, newsletterQueueIds, subscriptionItem => subscriptionItem.NewsletterQueues);
        }

        public async Task<SubscriptionItem> RemoveSubscribers(int id, int[] subscriberIds) {
            return await RemoveFromCollection(id, subscriberIds, subscriptionItem => subscriptionItem.Subscribers);
        }
    }
}
