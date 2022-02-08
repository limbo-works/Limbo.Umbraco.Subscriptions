using Limbo.Umbraco.Subscriptions.Subscribers.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.Subscribers.Extentions {
    public static class ServiceExtentions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<ISubscriberService, SubscriberService>();

            return services;
        }
    }
}
