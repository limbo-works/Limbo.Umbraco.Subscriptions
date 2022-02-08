using System;
using System.Data;
using System.Net;
using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services.Models;
using Limbo.Umbraco.Subscriptions.Bases.UintOfWorks;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscriptions.Bases.Services {
    public abstract class ServiceBase<TRepository> : UnitOfWork<TRepository>, IServiceBase<TRepository>
        where TRepository : IDbRepository {
        protected ILogger<ServiceBase<TRepository>> Logger { get; }

        public ServiceBase(TRepository repository, ILogger<ServiceBase<TRepository>> logger) : base(repository) {
            Logger = logger;
        }

        /// <summary>
        /// Executes an func that returns a value within a unit of work
        /// </summary>
        /// <typeparam name="TDomain"></typeparam>
        /// <param name="func"></param>
        /// <param name="statusCode"></param>
        /// <param name="IsolationLevel"></param>
        /// <returns></returns>
        protected virtual async Task<IServiceResponse<TDomain>> ExecuteServiceTask<TDomain>(Func<Task<TDomain>> func, HttpStatusCode statusCode, IsolationLevel IsolationLevel)
            where TDomain : class {
            try {
                await BeginUnitOfWorkAsync(IsolationLevel);
                var response = await func.Invoke().ConfigureAwait(false);
                await CommitUnitOfWorkAsync();
                return new ServiceResponse<TDomain>(statusCode, response);
            } catch (Exception ex) {
                Logger.LogError(ex, $"Task failed with {typeof(TDomain)}");
                return new ServiceResponse<TDomain>(HttpStatusCode.InternalServerError, null);
            }
        }
    }
}
