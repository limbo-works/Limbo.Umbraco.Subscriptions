using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.ApiAuthentication.Persistence.Contexts;
using Limbo.DataAccess.Repositories.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories {
    public class ApiClaimRepository : DbCrudRepositoryBase<ApiClaim>, IApiClaimRepository {
        public ApiClaimRepository(IApiAuthenticationContext dbContext, ILogger<DbCrudRepositoryBase<ApiClaim>> logger) : base(dbContext, logger) {
        }
    }
}
