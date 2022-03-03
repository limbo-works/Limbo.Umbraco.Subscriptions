using Limbo.Subscriptions.Persistence.SubscriptionItems.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.SubscriptionItems.Extensions {
    public static class RepositoryExtensions {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<ISubscriptionItemRepository, SubscriptionItemRepository>();

            return services;
        }
    }
}
