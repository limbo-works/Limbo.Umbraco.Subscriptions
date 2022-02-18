using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.DataAccess.Repositories.Crud;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories {
    public interface IApiClaimRepository : IDbCrudRepositoryBase<ApiClaim> {
    }
}