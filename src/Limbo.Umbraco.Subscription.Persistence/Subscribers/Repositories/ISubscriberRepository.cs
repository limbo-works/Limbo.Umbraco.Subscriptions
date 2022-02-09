using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;

namespace Limbo.Umbraco.Subscription.Persistence.Subscribers.Repositories {
    public interface ISubscriberRepository : IDbCrudRepository<Subscriber> {
        Task<Subscriber> AddCategories(int id, int[] categoryIds);
        Task<Subscriber> RemoveCategories(int id, int[] categoryIds);
        Task<Subscriber> AddSubscriptionItems(int id, int[] subscriptionItemIds);
        Task<Subscriber> RemoveSubscriptionItems(int id, int[] categoryIds);
    }
}
