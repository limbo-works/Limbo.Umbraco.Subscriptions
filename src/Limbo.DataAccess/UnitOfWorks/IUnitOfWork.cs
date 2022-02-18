using System.Data;
using System.Threading.Tasks;
using Limbo.DataAccess.Repositories;

namespace Limbo.DataAccess.UnitOfWorks {
    public interface IUnitOfWork<TRepository> where TRepository : IDbRepositoryBase {
        /// <summary>
        /// Begins a unit of work opreation
        /// </summary>
        /// <returns></returns>
        Task BeginUnitOfWorkAsync();

        /// <summary>
        /// Begins a unit of work opreation
        /// </summary>
        /// <param name="IsolationLevel"></param>
        /// <returns></returns>
        Task BeginUnitOfWorkAsync(IsolationLevel IsolationLevel);

        /// <summary>
        /// Commits a unit of work opreation
        /// </summary>
        /// <returns></returns>
        Task CommitUnitOfWorkAsync();
    }
}
