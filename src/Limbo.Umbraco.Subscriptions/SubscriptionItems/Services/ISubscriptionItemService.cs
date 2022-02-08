using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;

namespace Limbo.Umbraco.Subscriptions.SubscriptionItems.Services {
    public interface ISubscriptionItemService : ICrudServiceBase<SubscriptionItem, ISubscriptionItemRepository> {
    }
}