using Limbo.ApiAuthentication.Persistence.ApiKeys.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class RepositoryExtentions {
        /// <summary>
        /// Adds repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRespositories(this IServiceCollection services) {
            services
                .AddScoped<IApiKeyRepository, ApiKeyRepository>();

            return services;
        }
    }
}
