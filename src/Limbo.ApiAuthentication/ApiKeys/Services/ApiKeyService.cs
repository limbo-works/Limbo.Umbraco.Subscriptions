using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Repositories;
using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.ApiKeys.Services {
    public class ApiKeyService : CrudServiceBase<ApiKey, IApiKeyRepository>, IApiKeyService {
        public ApiKeyService(IApiKeyRepository repository, ILogger<ServiceBase<IApiKeyRepository>> logger) : base(repository, logger) {
        }
    }
}
