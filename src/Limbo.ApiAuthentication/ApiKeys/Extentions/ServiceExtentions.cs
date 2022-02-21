using Limbo.ApiAuthentication.ApiKeys.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.ApiKeys.Extentions {
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
                .AddScoped<IApiKeyService, ApiKeyService>();

            return services;
        }
    }
}
