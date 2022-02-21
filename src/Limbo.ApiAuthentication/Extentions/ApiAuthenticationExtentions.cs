using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Principal;
using System.Text;
using Limbo.ApiAuthentication.Persistence.Extentions;
using Limbo.ApiAuthentication.Settings.Extentions;
using Limbo.ApiAuthentication.Settings.Models;
using Limbo.ApiAuthentication.Tokens.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Limbo.ApiAuthentication.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class ApiAuthenticationExtentions {
        /// <summary>
        /// Adds api authentication
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="authorizationOptions"></param>
        /// <param name="connectionStringKey"></param>
        /// <param name="configurationSection"></param>
        /// <remarks>This must be placed after the AddUmbraco extention</remarks>
        /// <returns></returns>
        public static IServiceCollection AddLimboApiAuthentication(this IServiceCollection services, IConfiguration configuration, Action<AuthorizationOptions> authorizationOptions = default, string connectionStringKey = "Default", string configurationSection = "Limbo:ApiAuthentication") {
            services
                .AddSettings(configuration, configurationSection)
                .AddTokens()
                .AddPersistence(configuration, connectionStringKey)
                .AddApiAuthenticationServices();

            if (authorizationOptions == default) {
                services
                    .AddAuthorization();
            } else {
                services
                    .AddAuthorization(authorizationOptions);
            }

            return services;
        }

        /// <summary>
        /// Adds console logs to help debug Jwt errors
        /// </summary>
        /// <param name="app"></param>
        /// <param name="bindJwtSettings"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseJwtDebug(this IApplicationBuilder app, ApiAuthenticationSettings bindJwtSettings) {
            app.Use(async (context, next) => {
                try {
                    Console.WriteLine(context.User.Identity.Name);
                    Console.WriteLine(context.User.Identity.IsAuthenticated);
                    var authToken = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var validationParameters = new TokenValidationParameters() {
                        ValidateIssuerSigningKey = bindJwtSettings.ValidateAccessTokenSecretKey,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(bindJwtSettings.AccessTokenSecret)),
                        ValidateIssuer = bindJwtSettings.ValidateIssuer,
                        ValidIssuer = bindJwtSettings.ValidIssuer,
                        ValidateAudience = bindJwtSettings.ValidateAudience,
                        ValidAudience = bindJwtSettings.ValidAudience,
                        RequireExpirationTime = bindJwtSettings.RequireExpirationTime,
                        ValidateLifetime = bindJwtSettings.RequireExpirationTime,
                        ClockSkew = TimeSpan.Zero
                    }; ;

                    IPrincipal principal = tokenHandler.ValidateToken(authToken, validationParameters, out SecurityToken validatedToken);
                    Console.WriteLine("Success: " + validatedToken);
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                await next();
            });

            return app;
        }
    }
}
