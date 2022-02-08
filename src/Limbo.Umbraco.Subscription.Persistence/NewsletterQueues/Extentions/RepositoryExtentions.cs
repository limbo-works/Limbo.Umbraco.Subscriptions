using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Extentions {
    public static class RepositoryExtentions {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<INewsletterQueueRepository, NewsletterQueueRepository>();

            return services;
        }
    }
}
