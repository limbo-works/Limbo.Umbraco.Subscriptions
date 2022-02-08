using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Extentions {
    public static class SubscriptionItemExtentions {
        public static IServiceCollection AddSubcriptionItems(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
