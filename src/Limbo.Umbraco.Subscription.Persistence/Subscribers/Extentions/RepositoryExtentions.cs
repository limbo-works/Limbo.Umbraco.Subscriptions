using Limbo.Umbraco.Subscription.Persistence.Subscribers.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscription.Persistence.Subscribers.Extentions {
    public static class RepositoryExtentions {
        public static IServiceCollection AddRepositroies(this IServiceCollection services) {
            services
                .AddScoped<ISubscriberRepository, SubscriberRepository>();

            return services;
        }
    }
}
