using Limbo.Subscriptions.Categories.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Categories.Extensions {
    public static class ServiceExtensions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<ICategoryService, CategoryService>();

            return services;
        }
    }
}
