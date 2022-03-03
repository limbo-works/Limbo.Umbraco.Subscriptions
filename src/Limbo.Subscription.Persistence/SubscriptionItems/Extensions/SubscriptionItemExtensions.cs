using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.SubscriptionItems.Extensions {
    public static class SubscriptionItemExtensions {
        public static IServiceCollection AddSubcriptionItems(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
