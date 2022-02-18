using Limbo.ApiAuthentication.Persistence.Extentions;
using Limbo.ApiAuthentication.Settings.Extentions;
using Limbo.ApiAuthentication.Tokens.Extentions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Extentions {
    public static class ApiAuthenticationExtentions {
        public static IServiceCollection AddLimboApiAuthentication(this IServiceCollection services, IConfiguration configuration, string connectionStringKey = "Default", string configurationSection = "Limbo:ApiAuthentication") {
            services
                .AddSettings(configuration, configurationSection)
                .AddTokens()
                .AddAuthorization()
                .AddPersistence(configuration, connectionStringKey)
                .AddApiAuthenticationServices();

            return services;
        }
    }
}
