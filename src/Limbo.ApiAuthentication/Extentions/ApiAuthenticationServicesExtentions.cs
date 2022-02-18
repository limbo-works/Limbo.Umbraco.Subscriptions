using Limbo.ApiAuthentication.ApiClaims.Extentions;
using Limbo.ApiAuthentication.ApiKeys.Extentions;
using Limbo.ApiAuthentication.Authentication.Extentions;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Extentions {
    public static class ApiAuthenticationServicesExtentions {
        public static IServiceCollection AddApiAuthenticationServices(this IServiceCollection services) {
            services
                .AddApiKeys()
                .AddAuthenticationServices()
                .AddApiClaims();

            return services;
        }
    }
}
