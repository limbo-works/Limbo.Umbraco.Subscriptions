using System.Collections.Generic;
using System.Security.Claims;
using Limbo.ApiAuthentication.Tokens.Models;

namespace Limbo.ApiAuthentication.Tokens.Services {
    public interface ITokenService {
        ApiToken GenerateToken(List<Claim> claims = null);
    }
}