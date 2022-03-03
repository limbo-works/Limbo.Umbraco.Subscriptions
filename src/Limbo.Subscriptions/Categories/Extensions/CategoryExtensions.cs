using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Categories.Extensions {
    public static class CategoryExtensions {
        public static IServiceCollection AddCategories(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
