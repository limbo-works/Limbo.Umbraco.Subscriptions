using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.ApiAuthentication.Persistence.Contexts;
using Limbo.DataAccess.Contexts.Models;
using Limbo.DataAccess.Repositories.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories {
    public class ApiClaimRepository : DbCrudRepositoryBase<ApiClaim>, IApiClaimRepository {
        protected ApiClaimRepository(IApiAuthenticationContext dbContext, ILogger<DbCrudRepositoryBase<ApiClaim>> logger) : base(dbContext, logger) {
        }
    }
}
