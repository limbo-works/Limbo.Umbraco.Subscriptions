using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;
using Limbo.Umbraco.Subscriptions.Bases.Services.Models;

namespace Limbo.Umbraco.Subscriptions.SubscriptionItems.Services {
    public interface ISubscriptionItemService : ICrudServiceBase<SubscriptionItem, ISubscriptionItemRepository> {
        Task<IServiceResponse<SubscriptionItem>> AddCategories(int id, int[] categoryIds);
        Task<IServiceResponse<SubscriptionItem>> RemoveCategories(int id, int[] categoryIds);
        Task<IServiceResponse<SubscriptionItem>> AddSubscribers(int id, int[] subscriberIds);
        Task<IServiceResponse<SubscriptionItem>> RemoveSubscribers(int id, int[] subscriberIds);
        Task<IServiceResponse<SubscriptionItem>> AddNewsletterQueues(int id, int[] newsletterQueueIds);
        Task<IServiceResponse<SubscriptionItem>> RemoveNewsletterQueues(int id, int[] newsletterQueueIds);
    }
}