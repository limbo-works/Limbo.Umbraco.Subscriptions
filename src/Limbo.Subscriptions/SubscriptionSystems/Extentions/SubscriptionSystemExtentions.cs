using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.SubscriptionSystems.Extentions {
    public static class SubscriptionSystemExtentions {
        public static IServiceCollection AddSubscriptionSystems(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
