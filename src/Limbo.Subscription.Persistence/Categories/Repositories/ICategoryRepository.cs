using System.Threading.Tasks;
using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.Categories.Models;

namespace Limbo.Subscriptions.Persistence.Categories.Repositories {
    public interface ICategoryRepository : IDbCrudRepository<Category> {
        Task<Category> AddSubscribers(int id, int[] subscriberIds);
        Task<Category> RemoveSubscribers(int id, int[] subscriberIds);
        Task<Category> AddSubscriptionItems(int id, int[] subscriptionItemIds);
        Task<Category> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}
