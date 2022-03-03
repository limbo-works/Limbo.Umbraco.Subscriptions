using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.SubscriptionItems.Extensions {
    public static class SubscriptionItemExtensions {
        public static IServiceCollection AddSubscribtionItems(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
