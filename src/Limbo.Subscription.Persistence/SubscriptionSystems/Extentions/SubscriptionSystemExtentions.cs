using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.Extentions {
    public static class SubscriptionSystemExtentions {
        public static IServiceCollection AddSubscriptionSystems(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
