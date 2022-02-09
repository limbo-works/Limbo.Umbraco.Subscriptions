using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;

namespace Limbo.Umbraco.Subscription.Persistence.Categories.Repositories {
    public interface ICategoryRepository : IDbCrudRepository<Category> {
        Task<Category> AddSubscribers(int id, int[] subscriberIds);
        Task<Category> RemoveSubscribers(int id, int[] subscriberIds);
        Task<Category> AddSubscriptionItems(int id, int[] subscriptionItemIds);
        Task<Category> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}
