using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Types;
using Limbo.ApiAuthentication.Tokens.Models;
using Limbo.ApiAuthentication.Tokens.Services;
using Limbo.Subscriptions.Bases.GraphQL.Queries;

namespace Limbo.Subscriptions.Tokens.Queries {
    [ExtendObjectType(typeof(Query))]
    public class TokenQueries {
        private readonly ITokenService _tokenService;

        public TokenQueries(ITokenService tokenService) {
            _tokenService = tokenService;
        }

        public ApiToken GetApiToken(string apiKey) {
            return _tokenService.GenerateToken(new List<Claim> { new Claim(JwtRegisteredClaimNames.UniqueName, "nameHere") });
        }

        [Authorize]
        public string TestApiToken() {
            return "Token is vaild";
        }
    }
}
