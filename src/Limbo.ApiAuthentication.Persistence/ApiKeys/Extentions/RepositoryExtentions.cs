using Limbo.ApiAuthentication.Persistence.ApiKeys.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.Extentions {
    public static class RepositoryExtentions {
        public static IServiceCollection AddRespositories(this IServiceCollection services) {
            services
                .AddScoped<IApiKeyRepository, ApiKeyRepository>();

            return services;
        }
    }
}
