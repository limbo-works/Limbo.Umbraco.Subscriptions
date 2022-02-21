using Limbo.ApiAuthentication.Persistence.ApiClaims.Extentions;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Extentions;
using Limbo.ApiAuthentication.Persistence.Contexts.Extentions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class PersistenceExtentions {
        /// <summary>
        /// Adds persistence layer
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="connectionStringKey"></param>
        /// <returns></returns>
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration, string connectionStringKey) {
            services
                .AddContexts(configuration, connectionStringKey)
                .AddApiKeys()
                .AddApiClaims();

            return services;
        }
    }
}
