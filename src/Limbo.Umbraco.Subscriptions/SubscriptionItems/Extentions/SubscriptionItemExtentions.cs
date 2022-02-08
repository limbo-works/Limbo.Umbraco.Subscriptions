using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.SubscriptionItems.Extentions {
    public static class SubscriptionItemExtentions {
        public static IServiceCollection AddSubscribtionItems(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
