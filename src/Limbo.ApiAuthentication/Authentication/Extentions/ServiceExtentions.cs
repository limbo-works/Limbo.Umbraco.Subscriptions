using Limbo.ApiAuthentication.Authentication.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Authentication.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class ServiceExtentions {
        /// <summary>
        /// Adds services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<IApiKeyAuthenticatorService, ApiKeyAuthenticatorService>();

            return services;
        }
    }
}
