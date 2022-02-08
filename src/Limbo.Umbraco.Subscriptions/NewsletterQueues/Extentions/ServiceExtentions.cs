using Limbo.Umbraco.Subscriptions.NewsletterQueues.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.NewsletterQueues.Extentions {
    public static class ServiceExtentions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<INewsletterQueueService, NewsletterQueueService>();

            return services;
        }
    }
}
