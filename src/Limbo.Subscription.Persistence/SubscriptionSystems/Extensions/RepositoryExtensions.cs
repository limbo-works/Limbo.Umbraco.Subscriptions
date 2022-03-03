using Limbo.Subscriptions.Persistence.SubscriptionSystems.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.Extensions {
    public static class RepositoryExtensions {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<ISubscriptionSystemRepository, SubscriptionSystemRepository>();

            return services;
        }
    }
}
