using Limbo.Umbraco.Subscription.Persistence.Categories.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscription.Persistence.Categories.Extentions {
    public static class RepositoryExtentions {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}
