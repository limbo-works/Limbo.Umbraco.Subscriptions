using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.Extensions {
    public static class NewsletterQueueExtensions {
        public static IServiceCollection AddNewsletterQueues(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
