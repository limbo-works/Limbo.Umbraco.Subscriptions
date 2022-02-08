using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Extentions {
    public static class SubscriptionSystemExtentions {
        public static IServiceCollection AddSubscriptionSystems(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
