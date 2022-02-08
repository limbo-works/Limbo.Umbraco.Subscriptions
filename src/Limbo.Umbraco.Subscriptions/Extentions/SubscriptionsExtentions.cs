using Limbo.Umbraco.Subscription.Persistence.Extentions;
using Limbo.Umbraco.Subscriptions.Categories.Extentions;
using Limbo.Umbraco.Subscriptions.NewsletterQueues.Extentions;
using Limbo.Umbraco.Subscriptions.Subscribers.Extentions;
using Limbo.Umbraco.Subscriptions.SubscriptionItems.Extentions;
using Limbo.Umbraco.Subscriptions.SubscriptionSystems.Extentions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.Extentions {
    public static class SubscriptionsExtentions {
        public static IUmbracoBuilder AddSubscriptions(this IUmbracoBuilder builder, IConfiguration config) {
            builder.Services
                .AddPersistence(config)
                .AddSubscriptionServices();

            return builder;
        }

        public static IServiceCollection AddSubscriptionServices(this IServiceCollection services) {
            services
                .AddCategories()
                .AddNewsletterQueues()
                .AddSubscribers()
                .AddSubscribtionItems()
                .AddSubscriptionSystems();

            return services;
        }
    }
}
