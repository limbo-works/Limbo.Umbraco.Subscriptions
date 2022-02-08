using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;

namespace Limbo.Umbraco.Subscription.Persistence.Subscribers.Repositories {
    public interface ISubscriberRepository : IDbCrudRepository<Subscriber> {
    }
}
