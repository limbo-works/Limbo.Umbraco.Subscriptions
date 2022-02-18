using System;

namespace Limbo.ApiAuthentication.Settings.Models {
    public class ApiAuthenticationSettings {
        public string AccessTokenSecret { get; set; } = Guid.NewGuid().ToString();
        public string RefreshTokenSecret { get; set; } = Guid.NewGuid().ToString();
        public double AccessTokenExpirationMinutes { get; set; } = 10;
        public double RefreshTokenExpirationMinutes { get; set; } = 60;
        public string ValidIssuer { get; set; } = "";
        public string ValidAudience { get; set; } = "";
        public bool ValidateIssuerSigningKey { get; set; } = true;
        public bool ValidateIssuer { get; set; } = true;
        public bool ValidateAudience { get; set; } = true;
        public bool ValidateLifetime { get; set; } = true;
        public bool RequireExpirationTime { get; set; } = true;
        public bool RequireHttpsMetadata { get; set; } = true;
        public bool SaveToken { get; set; } = true;
    }
}
