using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.Subscribers.Extentions {
    public static class SubscriberExtentions {
        public static IServiceCollection AddSubscribers(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
