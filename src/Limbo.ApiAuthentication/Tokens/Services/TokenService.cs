using System;
using System.Collections.Generic;
using System.Security.Claims;
using Limbo.ApiAuthentication.Settings.Models;
using Limbo.ApiAuthentication.Tokens.Generators;
using Limbo.ApiAuthentication.Tokens.Models;

namespace Limbo.ApiAuthentication.Tokens.Services {
    /// <inheritdoc/>
    public class TokenService : ITokenService {
        private readonly ApiAuthenticationSettings _settings;
        private readonly ITokenGenerator _tokenGenerator;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="tokenGenerator"></param>
        public TokenService(ApiAuthenticationSettings settings, ITokenGenerator tokenGenerator) {
            _tokenGenerator = tokenGenerator;
            _settings = settings;
        }

        /// <inheritdoc/>
        public ApiToken GenerateToken(List<Claim> claims = null) {
            TimeSpan refreshTokenExpriesin = TimeSpan.FromMinutes(_settings.RefreshTokenExpirationMinutes);
            var refreshTokenExpriesOn = DateTime.UtcNow.Add(refreshTokenExpriesin);
            TimeSpan tokenExpriesIn = TimeSpan.FromMinutes(_settings.AccessTokenExpirationMinutes);
            var tokenExpriesOn = DateTime.UtcNow.Add(tokenExpriesIn);
            var token = new ApiToken {
                TokenExpiresOn = tokenExpriesOn,
                TokenExpiresIn = tokenExpriesIn.TotalMilliseconds,
                Token = _tokenGenerator.Generate(_settings.AccessTokenSecret, tokenExpriesOn, _settings.ValidIssuer, _settings.ValidAudience, claims),
                RefreshTokenExpriesOn = refreshTokenExpriesOn,
                RefreshTokenExpriesIn = refreshTokenExpriesin.TotalMilliseconds,
                RefreshToken = _tokenGenerator.Generate(_settings.RefreshTokenSecret, refreshTokenExpriesOn, _settings.ValidIssuer, _settings.ValidAudience, claims)
            };
            return token;
        }
    }
}
