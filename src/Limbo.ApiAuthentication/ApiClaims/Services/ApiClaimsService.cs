using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories;
using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.ApiClaims.Services {
    /// <inheritdoc/>
    public class ApiClaimsService : CrudServiceBase<ApiClaim, IApiClaimRepository>, IApiClaimService {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="logger"></param>
        public ApiClaimsService(IApiClaimRepository repository, ILogger<ServiceBase<IApiClaimRepository>> logger) : base(repository, logger) {
        }
    }
}
