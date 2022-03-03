using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Subscribers.Extensions {
    public static class SubscriberExtensions {
        public static IServiceCollection AddSubscribers(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
