using System.Threading.Tasks;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Services.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Repositories;

namespace Limbo.Subscriptions.SubscriptionItems.Services {
    public interface ISubscriptionItemService : ICrudServiceBase<SubscriptionItem, ISubscriptionItemRepository> {
        Task<IServiceResponse<SubscriptionItem>> AddCategories(int id, int[] categoryIds);
        Task<IServiceResponse<SubscriptionItem>> RemoveCategories(int id, int[] categoryIds);
        Task<IServiceResponse<SubscriptionItem>> AddSubscribers(int id, int[] subscriberIds);
        Task<IServiceResponse<SubscriptionItem>> RemoveSubscribers(int id, int[] subscriberIds);
        Task<IServiceResponse<SubscriptionItem>> AddNewsletterQueues(int id, int[] newsletterQueueIds);
        Task<IServiceResponse<SubscriptionItem>> RemoveNewsletterQueues(int id, int[] newsletterQueueIds);
    }
}