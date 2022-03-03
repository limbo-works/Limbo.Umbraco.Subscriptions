using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.Extensions {
    public static class SubscriptionSystemExtensions {
        public static IServiceCollection AddSubscriptionSystems(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
