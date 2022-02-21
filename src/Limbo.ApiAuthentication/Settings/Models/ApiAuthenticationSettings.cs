using System;

namespace Limbo.ApiAuthentication.Settings.Models {
    /// <summary>
    /// The api authentication settings available
    /// </summary>
    public class ApiAuthenticationSettings {
        /// <summary>
        /// The secret used to generate the access token
        /// </summary>
        public string AccessTokenSecret { get; set; } = Guid.NewGuid().ToString();
        /// <summary>
        /// The secret used to generate the refresh token
        /// </summary>
        public string RefreshTokenSecret { get; set; } = Guid.NewGuid().ToString();
        /// <summary>
        /// How long a access token should be vaild
        /// </summary>
        public double AccessTokenExpirationMinutes { get; set; } = 10;
        /// <summary>
        /// How long a refresh token should be vaild
        /// </summary>
        public double RefreshTokenExpirationMinutes { get; set; } = 60;
        /// <summary>
        /// The vaild issuer
        /// </summary>
        public string ValidIssuer { get; set; } = "";
        /// <summary>
        /// The vaild audience
        /// </summary>
        public string ValidAudience { get; set; } = "";
        /// <summary>
        /// Should we validate the <see cref="AccessTokenSecret"/>
        /// </summary>
        public bool ValidateAccessTokenSecretKey { get; set; } = true;
        /// <summary>
        /// Should we validate the <see cref="ValidIssuer"/>
        /// </summary>
        public bool ValidateIssuer { get; set; } = true;
        /// <summary>
        /// Should we validate the <see cref="ValidAudience"/>
        /// </summary>
        public bool ValidateAudience { get; set; } = true;
        /// <summary>
        /// Should we validate the lifetime of the token
        /// </summary>
        public bool ValidateLifetime { get; set; } = true;
        /// <summary>
        /// Should we reuire a expiration time
        /// </summary>
        public bool RequireExpirationTime { get; set; } = true;
        /// <summary>
        /// Should we require https metadata
        /// </summary>
        public bool RequireHttpsMetadata { get; set; } = true;
        /// <summary>
        /// Should we save the token after authentication
        /// </summary>
        public bool SaveToken { get; set; } = true;
    }
}
