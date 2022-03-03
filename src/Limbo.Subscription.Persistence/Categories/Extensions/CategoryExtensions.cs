using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Categories.Extensions {
    public static class CategoryExtensions {
        public static IServiceCollection AddCategories(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
