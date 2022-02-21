using Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class RepositoryExtentions {
        /// <summary>
        /// Adds repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<IApiClaimRepository, ApiClaimRepository>();

            return services;
        }
    }
}
