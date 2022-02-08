using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscriptions.SubscriptionSystems.Services {
    public class SubscriptionSystemService : CrudServiceBase<SubscriptionSystem, ISubscriptionSystemRepository>, ISubscriptionSystemService {
        public SubscriptionSystemService(ISubscriptionSystemRepository repository, ILogger<ServiceBase<ISubscriptionSystemRepository>> logger) : base(repository, logger) {
        }
    }
}
