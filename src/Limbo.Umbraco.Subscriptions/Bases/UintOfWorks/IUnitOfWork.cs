using System.Data;
using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories;

namespace Limbo.Umbraco.Subscriptions.Bases.UintOfWorks {
    public interface IUnitOfWork<TRepository> where TRepository : IDbRepository {
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
