using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Extentions {
    public static class RepositoryExtentions {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<ISubscriptionItemRepository, SubscriptionItemRepository>();

            return services;
        }
    }
}
