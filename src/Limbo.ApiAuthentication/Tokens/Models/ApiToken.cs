using System;

namespace Limbo.ApiAuthentication.Tokens.Models {
    /// <summary>
    /// A Api token
    /// </summary>
    public class ApiToken {
        /// <summary>
        /// The access token
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// The refresh token
        /// </summary>
        public string RefreshToken { get; set; }
        /// <summary>
        /// When the access token expires
        /// </summary>
        public DateTime TokenExpiresOn { get; set; }
        /// <summary>
        /// Milliseconds to access token expiration
        /// </summary>
        public double TokenExpiresIn { get; set; }
        /// <summary>
        /// When the refresh token expires
        /// </summary>
        public DateTime RefreshTokenExpriesOn { get; set; }
        /// <summary>
        /// Milliseconds to refresh token expiration
        /// </summary>
        public double RefreshTokenExpriesIn { get; set; }
    }
}
