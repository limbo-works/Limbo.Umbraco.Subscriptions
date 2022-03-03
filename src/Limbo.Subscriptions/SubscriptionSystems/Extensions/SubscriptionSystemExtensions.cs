using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.SubscriptionSystems.Extensions {
    public static class SubscriptionSystemExtensions {
        public static IServiceCollection AddSubscriptionSystems(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
