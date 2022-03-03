using Limbo.Subscriptions.Persistence.Categories.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Categories.Extensions {
    public static class RepositoryExtensions {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}
