using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Categories.Extentions {
    public static class CategoryExtentions {
        public static IServiceCollection AddCategories(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
