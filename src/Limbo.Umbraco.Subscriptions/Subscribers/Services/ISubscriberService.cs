using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;

namespace Limbo.Umbraco.Subscriptions.Subscribers.Services {
    public interface ISubscriberService : ICrudServiceBase<Subscriber, ISubscriberRepository> {
    }
}