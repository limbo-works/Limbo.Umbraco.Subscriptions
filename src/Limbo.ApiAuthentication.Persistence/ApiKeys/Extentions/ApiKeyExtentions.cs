using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.Extentions {
    public static class ApiKeyExtentions {
        public static IServiceCollection AddApiKeys(this IServiceCollection services) {
            services
                .AddRespositories();

            return services;
        }
    }
}
