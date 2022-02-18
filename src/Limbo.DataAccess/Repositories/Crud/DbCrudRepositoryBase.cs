using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Limbo.DataAccess.Contexts.Models;
using Limbo.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Limbo.DataAccess.Repositories.Crud {
    public class DbCrudRepositoryBase<TDomain> : DbRepositoryBase, IDbCrudRepositoryBase<TDomain>
        where TDomain : class, GenericId, new() {
        protected readonly ILogger<DbCrudRepositoryBase<TDomain>> logger;

        protected readonly DbSet<TDomain> dbSet;

        protected DbCrudRepositoryBase(IDbContext dbContext, ILogger<DbCrudRepositoryBase<TDomain>> logger) : base(dbContext) {
            dbSet = dbContext.Context.Set<TDomain>();
            this.logger = logger;
        }

        /// <inheritdoc/>
        public virtual async Task<TDomain> AddAsync(TDomain entity) {
            try {
                dbSet.Attach(entity);
                var createdEntity = await dbSet.AddAsync(entity);
                return createdEntity.Entity;
            } catch (Exception e) {
                logger.LogError(e, $"Failed while adding {typeof(TDomain)}");
                throw new TaskCanceledException("Task failed");
            }
        }

        /// <inheritdoc/>
        public virtual async Task DeleteByIdAsync(int id) {
            try {
                var entity = await GetByIdAsync(id).ConfigureAwait(false);
                if (entity != null) {
                    dbSet.Remove(entity);
                }
            } catch (Exception e) {
                logger.LogError(e, $"Failed on Delete with {typeof(TDomain)}");
                throw new TaskCanceledException("Task failed");
            }
        }

        /// <inheritdoc/>
        public virtual async Task<IEnumerable<TDomain>> GetAllAsync() {
            try {
                return await dbSet.ToListAsync();
            } catch (Exception e) {
                logger.LogError(e, $"Failed getting all {typeof(TDomain)}");
                throw new TaskCanceledException("Task failed");
            }
        }

        /// <inheritdoc/>
        public virtual async Task<TDomain> GetByIdAsync(int id) {
            try {
                return await dbSet.FindAsync(id);
            } catch (Exception e) {
                logger.LogError(e, $"Failed on GetById with {typeof(TDomain)} with id {id}");
                throw new TaskCanceledException("Task failed");
            }
        }

        public async Task<IQueryable<TDomain>> QueryDbSet() {
            try {
                return dbSet;
            } catch (Exception e) {
                logger.LogError(e, $"Failed query {typeof(TDomain)}");
                throw new TaskCanceledException("Task failed");
            }
        }

        /// <inheritdoc/>
        public virtual TDomain Update(TDomain entity) {
            try {
                dbSet.Attach(entity);
                var updatedEntity = dbSet.Update(entity);
                return updatedEntity.Entity;
            } catch (Exception e) {
                logger.LogError(e, $"Failed on Update with {typeof(TDomain)}");
                throw new ArgumentException("Failed updating entity");
            }
        }

        protected async Task<TDomain> AddToCollection<TCollectionItemType>(int id, int[] collectionIds, Func<TDomain, List<TCollectionItemType>> collectionKeySelector)
            where TCollectionItemType : class, GenericId, new() {
            try {
                var domain = await GetByIdAsync(id);
                var collection = collectionIds.Where(itemId => !collectionKeySelector(domain).Any(item => item.Id == itemId)).Select(itemId => new TCollectionItemType { Id = itemId });
                collectionKeySelector(domain).AddRange(collection);
                return domain;
            } catch (Exception e) {
                logger.LogError(e, $"Failed while adding collection {typeof(List<TCollectionItemType>)} to {typeof(TDomain)}");
                throw new TaskCanceledException("Task failed");
            }
        }

        protected async Task<TDomain> RemoveFromCollection<TCollectionItemType>(int id, int[] collectionIds, Func<TDomain, List<TCollectionItemType>> collectionKeySelector)
            where TCollectionItemType : class, GenericId, new() {
            try {
                var domain = await GetByIdAsync(id);
                var collection = collectionIds.Select(itemId => new TCollectionItemType { Id = itemId });
                collectionKeySelector(domain).RemoveAll(collectionItem => collection.Any(c => c.Id == collectionItem.Id));
                return domain;
            } catch (Exception e) {
                logger.LogError(e, $"Failed while removing collection {typeof(List<TCollectionItemType>)} from {typeof(TDomain)}");
                throw new TaskCanceledException("Task failed");
            }
        }

        Task<IEnumerable<TDomain>> IDbCrudRepositoryBase<TDomain>.GetAllAsync() {
            throw new NotImplementedException();
        }
    }
}
