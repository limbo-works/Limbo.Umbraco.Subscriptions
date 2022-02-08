using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscription.Persistence.Subscribers.Extentions {
    public static class SubscriberExtentions {
        public static IServiceCollection AddSubscribers(this IServiceCollection services) {
            services
                .AddRepositroies();

            return services;
        }
    }
}
