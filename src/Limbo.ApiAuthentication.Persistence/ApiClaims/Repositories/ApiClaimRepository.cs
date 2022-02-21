using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.ApiAuthentication.Persistence.Contexts;
using Limbo.DataAccess.Repositories.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories {
    /// <inheritdoc/>
    public class ApiClaimRepository : DbCrudRepositoryBase<ApiClaim>, IApiClaimRepository {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="logger"></param>
        public ApiClaimRepository(IApiAuthenticationContext dbContext, ILogger<DbCrudRepositoryBase<ApiClaim>> logger) : base(dbContext, logger) {
        }
    }
}
