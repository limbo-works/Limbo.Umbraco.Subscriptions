using System;
using System.Text;
using Limbo.ApiAuthentication.Settings.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Limbo.ApiAuthentication.Settings.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class SettingsExtentions {
        /// <summary>
        /// Adds settings
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="configurationSection"></param>
        /// <returns></returns>
        public static IServiceCollection AddSettings(this IServiceCollection services, IConfiguration configuration, string configurationSection) {
            var bindJwtSettings = new ApiAuthenticationSettings();
            configuration.Bind(configurationSection, bindJwtSettings);
            services.AddSingleton(bindJwtSettings);
            services.AddAuthentication(options => {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options => {
                options.RequireHttpsMetadata = bindJwtSettings.RequireHttpsMetadata;
                options.SaveToken = bindJwtSettings.SaveToken;
                options.TokenValidationParameters = new TokenValidationParameters() {
                    ValidateIssuerSigningKey = bindJwtSettings.ValidateAccessTokenSecretKey,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(bindJwtSettings.AccessTokenSecret)),
                    ValidateIssuer = bindJwtSettings.ValidateIssuer,
                    ValidIssuer = bindJwtSettings.ValidIssuer,
                    ValidateAudience = bindJwtSettings.ValidateAudience,
                    ValidAudience = bindJwtSettings.ValidAudience,
                    RequireExpirationTime = bindJwtSettings.RequireExpirationTime,
                    ValidateLifetime = bindJwtSettings.RequireExpirationTime,
                    ClockSkew = TimeSpan.Zero
                };
            });

            return services;
        }
    }
}
