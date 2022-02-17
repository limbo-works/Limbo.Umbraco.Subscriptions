using System.Threading.Tasks;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Repositories;
using Limbo.DataAccess.Services.Models;
using Limbo.DataAccess.Services.Crud;

namespace Limbo.Subscriptions.Subscribers.Services {
    public interface ISubscriberService : ICrudServiceBase<Subscriber, ISubscriberRepository> {
        Task<IServiceResponse<Subscriber>> AddCategories(int id, int[] categoryIds);
        Task<IServiceResponse<Subscriber>> RemoveCategories(int id, int[] categoryIds);
        Task<IServiceResponse<Subscriber>> AddSubscriptionItems(int id, int[] subscriptionItemIds);
        Task<IServiceResponse<Subscriber>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}