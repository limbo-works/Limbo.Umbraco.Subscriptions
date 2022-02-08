using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.UintOfWorks;

namespace Limbo.Umbraco.Subscriptions.Bases.Services {
    public interface IServiceBase<TRepository> : IUnitOfWork<TRepository>
        where TRepository : IDbRepository {
    }
}
