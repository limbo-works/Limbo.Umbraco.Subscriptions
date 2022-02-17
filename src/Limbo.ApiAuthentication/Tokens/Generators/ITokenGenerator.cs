using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Limbo.ApiAuthentication.Tokens.Generators {
    public interface ITokenGenerator {
        string Generate(string secretKey, DateTime expiresOn, string issuer, string audience, List<Claim> claims, string algorithm = "HS256");
    }
}
