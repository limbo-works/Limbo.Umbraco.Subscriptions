using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.Repositories {
    public interface ISubscriptionSystemRepository : IDbCrudRepository<SubscriptionSystem> {
    }
}
