using System.Threading.Tasks;
using Limbo.ApiAuthentication.Tokens.Models;

namespace Limbo.ApiAuthentication.Authentication.Services {
    public interface IApiKeyAuthenticatorService {
        Task<ApiToken> AuthenticateKey(string apikey);
    }
}