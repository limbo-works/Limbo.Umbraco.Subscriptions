using System.Collections.Generic;
using System.Threading.Tasks;
using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.Contexts;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.Persistence.SubscriptionItems.Repositories {
    /// <inheritdoc/>
    public class SubscriptionItemRepository : DbCrudRepositoryBase<SubscriptionItem>, ISubscriptionItemRepository {
        /// <inheritdoc/>
        public SubscriptionItemRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<SubscriptionItem>> logger) : base(dbContext, logger) {
        }

        /// <inheritdoc/>
        public async Task<SubscriptionItem> AddCategories(int id, int[] categoryIds) {
            return await AddToCollection(id, categoryIds, subscriptionItem => subscriptionItem.Categories ?? new List<Category>());
        }

        /// <inheritdoc/>
        public async Task<SubscriptionItem> AddNewsletterQueues(int id, int[] newsletterQueueIds) {
            return await AddToCollection(id, newsletterQueueIds, subscriptionItem => subscriptionItem.NewsletterQueues ?? new List<NewsletterQueue>());
        }

        /// <inheritdoc/>
        public async Task<SubscriptionItem> AddSubscribers(int id, int[] subscriberIds) {
            return await AddToCollection(id, subscriberIds, subscriptionItem => subscriptionItem.Subscribers ?? new List<Subscriber>());
        }

        /// <inheritdoc/>
        public async Task<SubscriptionItem> RemoveCategories(int id, int[] categoryIds) {
            return await RemoveFromCollection(id, categoryIds, subscriptionItem => subscriptionItem.Categories ?? new List<Category>());
        }

        /// <inheritdoc/>
        public async Task<SubscriptionItem> RemoveNewsletterQueues(int id, int[] newsletterQueueIds) {
            return await RemoveFromCollection(id, newsletterQueueIds, subscriptionItem => subscriptionItem.NewsletterQueues ?? new List<NewsletterQueue>());
        }

        /// <inheritdoc/>
        public async Task<SubscriptionItem> RemoveSubscribers(int id, int[] subscriberIds) {
            return await RemoveFromCollection(id, subscriberIds, subscriptionItem => subscriptionItem.Subscribers ?? new List<Subscriber>());
        }
    }
}
