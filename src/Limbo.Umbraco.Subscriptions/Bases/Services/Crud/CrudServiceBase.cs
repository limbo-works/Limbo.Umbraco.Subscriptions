using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscriptions.Bases.Services.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscriptions.Bases.Services.Crud {
    public abstract class CrudServiceBase<TDomain, TRepository> : ServiceBase<TRepository>, ICrudServiceBase<TDomain, TRepository>
        where TDomain : class
        where TRepository : IDbRepository, IDbCrudRepository<TDomain> {
        protected readonly TRepository repository;

        public CrudServiceBase(TRepository repository, ILogger<ServiceBase<TRepository>> logger) : base(repository, logger) {
            this.repository = repository;
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<TDomain>> Add(TDomain entity) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddAsync(entity);
            }, HttpStatusCode.Created, IsolationLevel.Snapshot);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<TDomain>> DeleteById(int id) {
            return await ExecuteServiceTask<TDomain>(async () => {
                await repository.DeleteByIdAsync(id);
                return null;
            }, HttpStatusCode.NoContent, IsolationLevel.Snapshot);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<IEnumerable<TDomain>>> GetAll() {
            return await ExecuteServiceTask(async () => {
                return await repository.GetAllAsync();
            }, HttpStatusCode.OK, IsolationLevel.Snapshot);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<TDomain>> GetById(int id) {
            return await ExecuteServiceTask(async () => {
                return await repository.GetByIdAsync(id);
            }, HttpStatusCode.OK, IsolationLevel.Snapshot);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<TDomain>> Update(TDomain entity) {
            return await ExecuteServiceTask(async () => {
                return await Task.Run(() => repository.Update(entity));
            }, HttpStatusCode.OK, IsolationLevel.Snapshot);
        }
    }
}
