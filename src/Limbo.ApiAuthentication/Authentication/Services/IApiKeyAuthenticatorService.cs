using System.Threading.Tasks;
using Limbo.ApiAuthentication.Tokens.Models;

namespace Limbo.ApiAuthentication.Authentication.Services {
    /// <summary>
    /// A service for authenticating api keys
    /// </summary>
    public interface IApiKeyAuthenticatorService {
        /// <summary>
        /// Checks if a api key is vaild
        /// </summary>
        /// <param name="apikey"></param>
        /// <returns>The api token or null</returns>
        Task<ApiToken> AuthenticateKey(string apikey);
    }
}