using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscriptions.Subscribers.Services {
    public class SubscriberService : CrudServiceBase<Subscriber, ISubscriberRepository>, ISubscriberService {
        public SubscriberService(ISubscriberRepository repository, ILogger<ServiceBase<ISubscriberRepository>> logger) : base(repository, logger) {
        }
    }
}
