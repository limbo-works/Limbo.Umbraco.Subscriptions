using Limbo.Subscriptions.Persistence.NewsletterQueues.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.Extensions {
    public static class RepositoryExtensions {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<INewsletterQueueRepository, NewsletterQueueRepository>();

            return services;
        }
    }
}
