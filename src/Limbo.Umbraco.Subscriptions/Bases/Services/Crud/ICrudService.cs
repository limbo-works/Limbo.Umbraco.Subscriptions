using System.Collections.Generic;
using System.Threading.Tasks;
using Limbo.Umbraco.Subscriptions.Bases.Services.Models;

namespace Limbo.Umbraco.Subscriptions.Bases.Services.Crud {
    public interface ICrudService<TDomain>
        where TDomain : class {
        /// <summary>
        /// Gets all entities from the database
        /// </summary>
        /// <returns></returns>
        Task<IServiceResponse<IEnumerable<TDomain>>> GetAll();

        /// <summary>
        /// Gets an entity by an id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IServiceResponse<TDomain>> GetById(int id);

        /// <summary>
        /// Deletes an entity from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IServiceResponse<TDomain>> DeleteById(int id);

        /// <summary>
        /// Updates a entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<IServiceResponse<TDomain>> Update(TDomain entity);

        /// <summary>
        /// Adds an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<IServiceResponse<TDomain>> Add(TDomain entity);
    }
}