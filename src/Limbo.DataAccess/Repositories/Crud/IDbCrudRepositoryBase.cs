﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Limbo.DataAccess.Models;

namespace Limbo.DataAccess.Repositories.Crud {
    public interface IDbCrudRepositoryBase<TDomain> : IDbRepositoryBase
        where TDomain : class, GenericId, new() {
        /// <summary>
        /// Queries the dbset
        /// </summary>
        /// <returns></returns>
        Task<IQueryable<TDomain>> QueryDbSet();

        /// <summary>
        /// Gets all entities
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TDomain>> GetAllAsync();

        /// <summary>
        /// Gets an entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TDomain> GetByIdAsync(int id);

        /// <summary>
        /// Deletes an entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteByIdAsync(int id);

        /// <summary>
        /// Updates an entity
        /// </summary>
        /// <param name="entity"></param>
        TDomain Update(TDomain entity);

        /// <summary>
        /// Adds an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TDomain> AddAsync(TDomain entity);
    }
}