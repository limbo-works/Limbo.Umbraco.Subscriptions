using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;

namespace Limbo.Umbraco.Subscriptions.Bases.Services.Crud {
    public interface ICrudServiceBase<TDomain, TRepository> : IServiceBase<TRepository>, ICrudService<TDomain>
        where TDomain : class
        where TRepository : IDbRepository, IDbCrudRepository<TDomain> {
    }
}
