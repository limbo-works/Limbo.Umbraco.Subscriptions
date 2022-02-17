using System.Threading.Tasks;
using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;

namespace Limbo.Subscriptions.Persistence.SubscriptionItems.Repositories {
    public interface ISubscriptionItemRepository : IDbCrudRepository<SubscriptionItem> {
        Task<SubscriptionItem> AddCategories(int id, int[] categoryIds);
        Task<SubscriptionItem> AddNewsletterQueues(int id, int[] newsletterQueueIds);
        Task<SubscriptionItem> AddSubscribers(int id, int[] subscriberIds);
        Task<SubscriptionItem> RemoveCategories(int id, int[] categoryIds);
        Task<SubscriptionItem> RemoveNewsletterQueues(int id, int[] newsletterQueueIds);
        Task<SubscriptionItem> RemoveSubscribers(int id, int[] subscriberIds);
    }
}
