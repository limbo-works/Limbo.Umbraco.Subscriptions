using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Repositories {
    public interface ISubscriptionItemRepository : IDbCrudRepository<SubscriptionItem> {
    }
}
