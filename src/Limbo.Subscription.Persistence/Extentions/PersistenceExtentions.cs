using Limbo.Subscriptions.Persistence.Categories.Extentions;
using Limbo.Subscriptions.Persistence.Contexts.Extentions;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Extentions;
using Limbo.Subscriptions.Persistence.Subscribers.Extentions;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Extentions;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Extentions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Extentions {
    public static class PersistenceExtentions {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration, string connectionStringKey) {
            services
                .AddContexts(configuration, connectionStringKey)
                .AddCategories()
                .AddNewsletterQueues()
                .AddSubscribers()
                .AddSubcriptionItems()
                .AddSubscriptionSystems();

            return services;
        }
    }
}
