using Limbo.Subscriptions.Categories.Extentions;
using Limbo.Subscriptions.NewsletterQueues.Extentions;
using Limbo.Subscriptions.Subscribers.Extentions;
using Limbo.Subscriptions.SubscriptionItems.Extentions;
using Limbo.Subscriptions.SubscriptionSystems.Extentions;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Extentions {
    public static class SubscriptionsServiceExtentions {

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