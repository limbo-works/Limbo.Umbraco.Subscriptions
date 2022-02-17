using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace Limbo.ApiAuthentication.Tokens.Generators {
    public class TokenGenerator : ITokenGenerator {
        private readonly ILogger<TokenGenerator> _logger;

        public TokenGenerator(ILogger<TokenGenerator> logger) {
            _logger = logger;
        }

        public string Generate(string secretKey, DateTime expiresOn, string issuer, string audience, List<Claim> claims, string algorithm = SecurityAlgorithms.HmacSha256) {
            if (string.IsNullOrWhiteSpace(issuer)) {
                _logger.LogWarning("Issuer not set on token");
            }

            if (string.IsNullOrWhiteSpace(audience)) {
                _logger.LogWarning("Audience not set on token");
            }

            var key = Encoding.UTF8.GetBytes(secretKey);
            var jwtToken = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: expiresOn,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), algorithm));

            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }
    }
}
