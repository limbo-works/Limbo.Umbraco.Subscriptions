using System.Collections.Generic;
using System.Security.Claims;
using Limbo.ApiAuthentication.Tokens.Models;

namespace Limbo.ApiAuthentication.Tokens.Services {
    /// <summary>
    /// A service for managing tokens
    /// </summary>
    public interface ITokenService {
        /// <summary>
        /// Generates a token
        /// </summary>
        /// <param name="claims"></param>
        /// <returns></returns>
        ApiToken GenerateToken(List<Claim> claims = null);
    }
}