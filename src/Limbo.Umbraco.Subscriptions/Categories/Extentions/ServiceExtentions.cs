using Limbo.Umbraco.Subscriptions.Categories.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.Categories.Extentions {
    public static class ServiceExtentions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<ICategoryService, CategoryService>();

            return services;
        }
    }
}
