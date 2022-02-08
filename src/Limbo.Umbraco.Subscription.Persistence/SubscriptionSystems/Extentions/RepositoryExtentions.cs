using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Extentions {
    public static class RepositoryExtentions {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<ISubscriptionSystemRepository, SubscriptionSystemRepository>();

            return services;
        }
    }
}
