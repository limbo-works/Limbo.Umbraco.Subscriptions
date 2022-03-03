using Limbo.Subscriptions.Persistence.Categories.Extensions;
using Limbo.Subscriptions.Persistence.Contexts.Extensions;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Extensions;
using Limbo.Subscriptions.Persistence.Subscribers.Extensions;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Extensions;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Extensions {
    public static class PersistenceExtensions {
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
