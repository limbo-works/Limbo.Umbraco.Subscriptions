using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Subscribers.Extensions {
    public static class SubscriberExtensions {
        public static IServiceCollection AddSubscribers(this IServiceCollection services) {
            services
                .AddRepositroies();

            return services;
        }
    }
}
