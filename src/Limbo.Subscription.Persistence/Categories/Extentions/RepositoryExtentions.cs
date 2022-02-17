using Limbo.Subscriptions.Persistence.Categories.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Categories.Extentions {
    public static class RepositoryExtentions {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}
