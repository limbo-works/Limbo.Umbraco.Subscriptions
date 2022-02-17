using Limbo.Subscriptions.Persistence.NewsletterQueues.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.Extentions {
    public static class RepositoryExtentions {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<INewsletterQueueRepository, NewsletterQueueRepository>();

            return services;
        }
    }
}
