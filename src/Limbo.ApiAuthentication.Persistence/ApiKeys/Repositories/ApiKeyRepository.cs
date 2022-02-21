using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.ApiAuthentication.Persistence.Contexts;
using Limbo.DataAccess.Repositories.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.Repositories {
    /// <inheritdoc/>
    public class ApiKeyRepository : DbCrudRepositoryBase<ApiKey>, IApiKeyRepository {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="logger"></param>
        public ApiKeyRepository(IApiAuthenticationContext dbContext, ILogger<DbCrudRepositoryBase<ApiKey>> logger) : base(dbContext, logger) {
        }
    }
}
