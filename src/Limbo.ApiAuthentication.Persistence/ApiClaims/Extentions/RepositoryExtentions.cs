using Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Extentions {
    public static class RepositoryExtentions {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<IApiClaimRepository, ApiClaimRepository>();

            return services;
        }
    }
}
