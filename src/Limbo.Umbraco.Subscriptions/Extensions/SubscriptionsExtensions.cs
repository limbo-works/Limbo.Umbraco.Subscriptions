using System;
using Limbo.Subscriptions.Extensions;
using Microsoft.Extensions.Configuration;
using Umbraco.Cms.Core.DependencyInjection;
using Limbo.MailSystem.Extensions;
using Limbo.Umbraco.Subscriptions.Content.Events.Extensions;
using Limbo.Umbraco.Subscriptions.Extensions.Models;

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
            var subscriptionConfiguration = new SubscriptionsConfigurationOptions();
            subscriptionConfigurationOptions.Invoke(subscriptionConfiguration);

            builder.Services.AddSubscriptions(config, subscriptionConfiguration.ConnectionStringKey, subscriptionConfiguration.DataAccessConfigurationSection, subscriptionConfiguration.GraphQLExtensions)
                .AddMailSystem(config, subscriptionConfiguration.MailConfigurationSection);

            builder.AddEvents();

            return builder;
        }
    }
}
