using Limbo.DataAccess.Models;
using Limbo.DataAccess.Repositories;
using Limbo.DataAccess.Repositories.Crud;

namespace Limbo.DataAccess.Services.Crud {
    public interface ICrudServiceBase<TDomain, TRepository> : IServiceBase<TRepository>, ICrudService<TDomain>
        where TDomain : class, GenericId, new()
        where TRepository : IDbRepositoryBase, IDbCrudRepositoryBase<TDomain> {
    }
}
