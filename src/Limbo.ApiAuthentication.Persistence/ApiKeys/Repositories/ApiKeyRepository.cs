using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.ApiAuthentication.Persistence.Contexts;
using Limbo.DataAccess.Contexts.Models;
using Limbo.DataAccess.Repositories.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.Repositories {
    public class ApiKeyRepository : DbCrudRepositoryBase<ApiKey>, IApiKeyRepository {
        public ApiKeyRepository(IApiAuthenticationContext dbContext, ILogger<DbCrudRepositoryBase<ApiKey>> logger) : base(dbContext, logger) {
        }
    }
}
