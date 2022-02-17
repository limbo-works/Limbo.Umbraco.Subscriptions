namespace Limbo.ApiAuthentication.Tokens.Validators {
    public interface IRefreshTokenValidator {
        bool Validate(string refreshToken, string issuer, string audience);
    }
}