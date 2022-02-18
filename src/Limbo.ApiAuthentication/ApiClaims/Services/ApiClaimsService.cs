using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories;
using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.ApiClaims.Services {
    public class ApiClaimsService : CrudServiceBase<ApiClaim, IApiClaimRepository>, IApiClaimService {
        public ApiClaimsService(IApiClaimRepository repository, ILogger<ServiceBase<IApiClaimRepository>> logger) : base(repository, logger) {
        }
    }
}
