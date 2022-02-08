using Limbo.Umbraco.Subscription.Persistence.Extentions;
using Microsoft.Extensions.Configuration;
using Umbraco.Cms.Core.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.Extentions {
    public static class SubscriptionsExtentions {
        public static IUmbracoBuilder AddSubscriptions(this IUmbracoBuilder builder, IConfiguration config) {
            builder.Services
                .AddPersistence(config);

            return builder;
        }
    }
}
