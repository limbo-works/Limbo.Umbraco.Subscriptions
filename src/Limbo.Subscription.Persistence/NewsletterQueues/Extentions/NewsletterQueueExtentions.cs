using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.Extentions {
    public static class NewsletterQueueExtentions {
        public static IServiceCollection AddNewsletterQueues(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
