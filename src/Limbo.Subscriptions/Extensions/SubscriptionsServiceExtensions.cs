using Limbo.Subscriptions.Categories.Extensions;
using Limbo.Subscriptions.NewsletterQueues.Extensions;
using Limbo.Subscriptions.Subscribers.Extensions;
using Limbo.Subscriptions.SubscriptionItems.Extensions;
using Limbo.Subscriptions.SubscriptionSystems.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Extensions {
    public static class SubscriptionsServiceExtensions {

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