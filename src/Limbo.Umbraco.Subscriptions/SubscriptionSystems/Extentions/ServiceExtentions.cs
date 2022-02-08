using Limbo.Umbraco.Subscriptions.SubscriptionSystems.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.SubscriptionSystems.Extentions {
    public static class ServiceExtentions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<ISubscriptionSystemService, SubscriptionSystemService>();

            return services;
        }
    }
}
