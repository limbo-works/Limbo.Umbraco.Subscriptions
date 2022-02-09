using Limbo.Umbraco.Subscription.Persistence.Bases.Model;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;

namespace Limbo.Umbraco.Subscriptions.Bases.Services.Crud {
    public interface ICrudServiceBase<TDomain, TRepository> : IServiceBase<TRepository>, ICrudService<TDomain>
        where TDomain : class, GenericId, new()
        where TRepository : IDbRepository, IDbCrudRepository<TDomain> {
    }
}
