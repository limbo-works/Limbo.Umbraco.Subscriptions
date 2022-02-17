using System;

namespace Limbo.ApiAuthentication.Tokens.Models {
    public class ApiToken {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime TokenExpiresOn { get; set; }
        public double TokenExpiresIn { get; set; }
        public DateTime RefreshTokenExpriesOn { get; set; }
        public double RefreshTokenExpriesIn { get; set; }
    }
}
