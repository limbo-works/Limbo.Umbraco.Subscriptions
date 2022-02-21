using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class ApiClaimExtentions {
        /// <summary>
        /// Adds api claims
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApiClaims(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
