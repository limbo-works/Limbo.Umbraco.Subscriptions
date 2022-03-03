using Limbo.DataAccess.Extensions;
using Limbo.Subscriptions.Persistence.Categories.Extensions;
using Limbo.Subscriptions.Persistence.Contexts.Extensions;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Extensions;
using Limbo.Subscriptions.Persistence.Subscribers.Extensions;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Extensions;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class PersistenceExtensions {
        /// <summary>
        /// Adds persistence
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="connectionStringKey"></param>
        /// <param name="dataAccessConfigurationSection"></param>
        /// <returns></returns>
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration, string connectionStringKey, string dataAccessConfigurationSection) {
            services
                .AddContexts(configuration, connectionStringKey)
                .AddCategories()
                .AddNewsletterQueues()
                .AddSubscribers()
                .AddSubcriptionItems()
                .AddSubscriptionSystems()
                .AddDataAccess(configuration, dataAccessConfigurationSection);

            return services;
        }
    }
}
