using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.DataAccess.Repositories.Crud;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories {
    /// <summary>
    /// A repository for interacting with api claims
    /// </summary>
    public interface IApiClaimRepository : IDbCrudRepositoryBase<ApiClaim> {
    }
}