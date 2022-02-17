using Limbo.DataAccess.Repositories;
using Limbo.DataAccess.UnitOfWorks;

namespace Limbo.DataAccess.Services {
    public interface IServiceBase<TRepository> : IUnitOfWork<TRepository>
        where TRepository : IDbRepository {
    }
}
