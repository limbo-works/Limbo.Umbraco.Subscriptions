using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscription.Persistence.Categories.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;
using Limbo.Umbraco.Subscriptions.Bases.Services.Models;

namespace Limbo.Umbraco.Subscriptions.Categories.Services {
    public interface ICategoryService : ICrudServiceBase<Category, ICategoryRepository> {
        Task<IServiceResponse<Category>> AddSubscribers(int id, int[] subscriberIds);
        Task<IServiceResponse<Category>> RemoveSubscribers(int id, int[] subscriberIds);
        Task<IServiceResponse<Category>> AddSubscriptionItems(int id, int[] subscriptionItemIds);
        Task<IServiceResponse<Category>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}
