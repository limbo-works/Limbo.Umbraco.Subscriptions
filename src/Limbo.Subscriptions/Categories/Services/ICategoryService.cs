using System.Threading.Tasks;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.Categories.Repositories;
using Limbo.DataAccess.Services.Models;
using Limbo.DataAccess.Services.Crud;

namespace Limbo.Subscriptions.Categories.Services {
    public interface ICategoryService : ICrudServiceBase<Category, ICategoryRepository> {
        Task<IServiceResponse<Category>> AddSubscribers(int id, int[] subscriberIds);
        Task<IServiceResponse<Category>> RemoveSubscribers(int id, int[] subscriberIds);
        Task<IServiceResponse<Category>> AddSubscriptionItems(int id, int[] subscriptionItemIds);
        Task<IServiceResponse<Category>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}
