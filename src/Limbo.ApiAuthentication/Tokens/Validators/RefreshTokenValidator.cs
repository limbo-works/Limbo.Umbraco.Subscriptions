using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Limbo.ApiAuthentication.Settings.Models;
using Microsoft.IdentityModel.Tokens;

namespace Limbo.ApiAuthentication.Tokens.Validators {
    public class RefreshTokenValidator : IRefreshTokenValidator {
        private readonly ApiAuthenticationSettings _settings;

        public RefreshTokenValidator(ApiAuthenticationSettings settings) {
            _settings = settings;
        }

        public bool Validate(string refreshToken, string issuer, string audience) {
            var validationParameters = new TokenValidationParameters {
                ValidateIssuerSigningKey = _settings.ValidateIssuerSigningKey,
                ValidateIssuer = _settings.ValidateIssuer,
                ValidateAudience = _settings.ValidateAudience,
                ValidateLifetime = _settings.ValidateLifetime,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_settings.RefreshTokenSecret)),
                ValidIssuer = issuer,
                ValidAudience = audience,
                ClockSkew = TimeSpan.Zero
            };

            JwtSecurityTokenHandler jwtSecurityTokenHandler = new();
            try {
                jwtSecurityTokenHandler.ValidateToken(refreshToken, validationParameters,
                    out SecurityToken validatedToken);
                return true;
            } catch (Exception) {
                return false;
            }
        }
    }
}
