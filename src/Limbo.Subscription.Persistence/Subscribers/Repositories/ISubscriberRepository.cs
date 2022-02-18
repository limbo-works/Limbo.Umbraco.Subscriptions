using System.Threading.Tasks;
using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.Subscribers.Models;

namespace Limbo.Subscriptions.Persistence.Subscribers.Repositories {
    public interface ISubscriberRepository : IDbCrudRepositoryBase<Subscriber> {
        Task<Subscriber> AddCategories(int id, int[] categoryIds);
        Task<Subscriber> RemoveCategories(int id, int[] categoryIds);
        Task<Subscriber> AddSubscriptionItems(int id, int[] subscriptionItemIds);
        Task<Subscriber> RemoveSubscriptionItems(int id, int[] categoryIds);
    }
}
