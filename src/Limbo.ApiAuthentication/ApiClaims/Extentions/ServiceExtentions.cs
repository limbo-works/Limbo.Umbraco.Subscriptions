using Limbo.ApiAuthentication.ApiClaims.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.ApiClaims.Extentions {
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
                .AddScoped<IApiClaimService, ApiClaimsService>();

            return services;
        }
    }
}
