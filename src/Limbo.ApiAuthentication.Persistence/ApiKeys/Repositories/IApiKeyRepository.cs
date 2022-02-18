using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.DataAccess.Repositories.Crud;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.Repositories {
    public interface IApiKeyRepository : IDbCrudRepositoryBase<ApiKey> {
    }
}