using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Extentions {
    public static class ApiClaimExtentions {
        public static IServiceCollection AddApiClaims(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
