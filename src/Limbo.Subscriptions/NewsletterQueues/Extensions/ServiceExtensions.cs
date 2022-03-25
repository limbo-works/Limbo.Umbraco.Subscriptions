using Limbo.Subscriptions.NewsletterQueues.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.NewsletterQueues.Extensions {
    public static class ServiceExtensions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddTransient<INewsletterQueueService, NewsletterQueueService>();

            return services;
        }
    }
}
