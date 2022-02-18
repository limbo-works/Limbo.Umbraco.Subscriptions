using System;
using Limbo.ApiAuthentication.Persistence.Extentions;
using Limbo.ApiAuthentication.Settings.Extentions;
using Limbo.ApiAuthentication.Tokens.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Extentions {
    public static class ApiAuthenticationExtentions {
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
    }
}
