using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Repositories;
using Limbo.DataAccess.Services.Crud;

namespace Limbo.ApiAuthentication.ApiKeys.Services {
    /// <summary>
    /// A service for interacting with api keys
    /// </summary>
    public interface IApiKeyService : ICrudServiceBase<ApiKey, IApiKeyRepository> {
    }
}