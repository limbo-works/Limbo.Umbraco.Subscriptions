using Limbo.ApiAuthentication.Persistence.ApiClaims.Extentions;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Extentions;
using Limbo.ApiAuthentication.Persistence.Contexts.Extentions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.Extentions {
    public static class PersistenceExtentions {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration, string connectionStringKey) {
            services
                .AddContexts(configuration, connectionStringKey)
                .AddApiKeys()
                .AddApiClaims();

            return services;
        }
    }
}
