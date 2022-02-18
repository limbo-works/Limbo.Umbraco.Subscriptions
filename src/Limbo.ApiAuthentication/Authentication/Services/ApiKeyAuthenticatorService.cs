using System;
using System.Linq;
using System.Threading.Tasks;
using Limbo.ApiAuthentication.ApiKeys.Services;
using Limbo.ApiAuthentication.Tokens.Models;
using Limbo.ApiAuthentication.Tokens.Services;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.Authentication.Services {
    public class ApiKeyAuthenticatorService : IApiKeyAuthenticatorService {
        private readonly ITokenService _tokenService;
        private readonly IApiKeyService _apiKeyService;
        private readonly ILogger<ApiKeyAuthenticatorService> _logger;

        public ApiKeyAuthenticatorService(ITokenService tokenService, IApiKeyService apiKeyService, ILogger<ApiKeyAuthenticatorService> logger) {
            _tokenService = tokenService;
            _apiKeyService = apiKeyService;
            _logger = logger;
        }

        public async Task<ApiToken> AuthenticateKey(string apikey) {
            try {
                var apiKeyExists = (await _apiKeyService.QueryDbSet()).ReponseValue.Where(item => item.Key == apikey).FirstOrDefault() != default;
                return _tokenService.GenerateToken();
            } catch (Exception ex) {
                _logger.LogError(ex, $"Authentication failed for key: {apikey}");
                return null;
            }
        }
    }
}
