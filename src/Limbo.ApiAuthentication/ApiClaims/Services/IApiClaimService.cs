using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories;
using Limbo.DataAccess.Services.Crud;

namespace Limbo.ApiAuthentication.ApiClaims.Services {
    /// <summary>
    /// A service for interacting with api claims
    /// </summary>
    public interface IApiClaimService : ICrudServiceBase<ApiClaim, IApiClaimRepository> {
    }
}