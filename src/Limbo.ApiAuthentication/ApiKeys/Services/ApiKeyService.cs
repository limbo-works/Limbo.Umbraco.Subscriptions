using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Repositories;
using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.ApiKeys.Services {
    /// <inheritdoc/>
    public class ApiKeyService : CrudServiceBase<ApiKey, IApiKeyRepository>, IApiKeyService {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="logger"></param>
        public ApiKeyService(IApiKeyRepository repository, ILogger<ServiceBase<IApiKeyRepository>> logger) : base(repository, logger) {
        }
    }
}
