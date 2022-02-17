using Limbo.Subscriptions.Persistence.SubscriptionSystems.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.Extentions {
    public static class RepositoryExtentions {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<ISubscriptionSystemRepository, SubscriptionSystemRepository>();

            return services;
        }
    }
}
