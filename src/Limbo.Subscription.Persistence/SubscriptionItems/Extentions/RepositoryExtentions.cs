using Limbo.Subscriptions.Persistence.SubscriptionItems.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.SubscriptionItems.Extentions {
    public static class RepositoryExtentions {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<ISubscriptionItemRepository, SubscriptionItemRepository>();

            return services;
        }
    }
}
