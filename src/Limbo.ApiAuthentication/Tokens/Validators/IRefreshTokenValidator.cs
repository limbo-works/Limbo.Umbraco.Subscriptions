namespace Limbo.ApiAuthentication.Tokens.Validators {
    /// <summary>
    /// A refresh token validator
    /// </summary>
    public interface IRefreshTokenValidator {
        /// <summary>
        /// Checks to see if a refresh token is valid
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <param name="issuer"></param>
        /// <param name="audience"></param>
        /// <returns></returns>
        bool Validate(string refreshToken, string issuer, string audience);
    }
}