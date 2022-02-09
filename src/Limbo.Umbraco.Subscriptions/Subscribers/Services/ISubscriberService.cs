using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;
using Limbo.Umbraco.Subscriptions.Bases.Services.Models;

namespace Limbo.Umbraco.Subscriptions.Subscribers.Services {
    public interface ISubscriberService : ICrudServiceBase<Subscriber, ISubscriberRepository> {
        Task<IServiceResponse<Subscriber>> AddCategories(int id, int[] categoryIds);
        Task<IServiceResponse<Subscriber>> RemoveCategories(int id, int[] categoryIds);
        Task<IServiceResponse<Subscriber>> AddSubscriptionItems(int id, int[] subscriptionItemIds);
        Task<IServiceResponse<Subscriber>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}