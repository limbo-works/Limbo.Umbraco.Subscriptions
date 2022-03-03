using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.NewsletterQueues.Extensions {
    public static class NewsletterQueueExtensions {
        public static IServiceCollection AddNewsletterQueues(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
