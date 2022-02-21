using Limbo.ApiAuthentication.ApiClaims.Extentions;
using Limbo.ApiAuthentication.ApiKeys.Extentions;
using Limbo.ApiAuthentication.Authentication.Extentions;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class ApiAuthenticationServicesExtentions {
        /// <summary>
        /// Adds api authentication services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApiAuthenticationServices(this IServiceCollection services) {
            services
                .AddApiKeys()
                .AddAuthenticationServices()
                .AddApiClaims();

            return services;
        }
    }
}
