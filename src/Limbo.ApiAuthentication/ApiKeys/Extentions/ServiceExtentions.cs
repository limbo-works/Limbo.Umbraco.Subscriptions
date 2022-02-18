using Limbo.ApiAuthentication.ApiKeys.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.ApiKeys.Extentions {
    public static class ServiceExtentions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<IApiKeyService, ApiKeyService>();

            return services;
        }
    }
}
