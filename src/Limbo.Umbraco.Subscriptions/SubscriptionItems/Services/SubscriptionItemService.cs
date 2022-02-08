using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscriptions.SubscriptionItems.Services {
    public class SubscriptionItemService : CrudServiceBase<SubscriptionItem, ISubscriptionItemRepository>, ISubscriptionItemService {
        public SubscriptionItemService(ISubscriptionItemRepository repository, ILogger<ServiceBase<ISubscriptionItemRepository>> logger) : base(repository, logger) {
        }
    }
}
