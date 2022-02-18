using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Repositories;
using Limbo.DataAccess.Services.Crud;

namespace Limbo.ApiAuthentication.ApiKeys.Services {
    public interface IApiKeyService : ICrudServiceBase<ApiKey, IApiKeyRepository> {
    }
}