using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.NewsletterQueues.Extentions {
    public static class NewsletterQueueExtentions {
        public static IServiceCollection AddNewsletterQueues(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
