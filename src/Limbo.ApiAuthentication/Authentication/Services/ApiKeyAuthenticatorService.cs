using Limbo.ApiAuthentication.Tokens.Models;
using Limbo.ApiAuthentication.Tokens.Services;

namespace Limbo.ApiAuthentication.Authentication.Services {
    public class ApiKeyAuthenticatorService {
        private readonly ITokenService _tokenService;

        public ApiKeyAuthenticatorService(ITokenService tokenService) {
            _tokenService = tokenService;
        }

        public ApiToken AuthenticateKey(string apikey) {
            return _tokenService.GenerateToken();
        }
    }
}
