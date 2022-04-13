using System;
using Limbo.Subscriptions.Extensions;
using Microsoft.Extensions.Configuration;
using Umbraco.Cms.Core.DependencyInjection;
using Limbo.Umbraco.Subscriptions.Content.Events.Extensions;
using Limbo.Umbraco.Subscriptions.Queues.Jobs.Extensions;
using Limbo.Umbraco.Subscriptions.Extensions.Options;

namespace Limbo.Umbraco.Subscriptions.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class SubscriptionsExtensions {
        /// <summary>
        /// Adds subscriptions
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="config"></param>
        /// <param name="subscriptionConfigurationOptions"></param>
        /// <returns></returns>
        public static IUmbracoBuilder AddSubscriptions(this IUmbracoBuilder builder, IConfiguration config, Action<SubscriptionsConfigurationOptions> subscriptionConfigurationOptions) {
            var subscriptionConfiguration = new SubscriptionsConfigurationOptions(config);
            subscriptionConfigurationOptions.Invoke(subscriptionConfiguration);

            return AddSubcriptions(builder, subscriptionConfiguration);
        }

        /// <summary>
        /// Adds subscriptions
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="subscriptionConfigurationOptions"></param>
        /// <returns></returns>
        public static IUmbracoBuilder AddSubcriptions(IUmbracoBuilder builder, SubscriptionsConfigurationOptions subscriptionConfigurationOptions) {
            builder.Services.AddSubscriptions(subscriptionConfigurationOptions.SubscriptionOptions);

            builder.AddEvents();

            builder.Services.AddJobs();

            return builder;
        }
    }
}
