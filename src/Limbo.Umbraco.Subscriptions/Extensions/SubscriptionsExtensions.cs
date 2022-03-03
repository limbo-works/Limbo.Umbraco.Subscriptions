using HotChocolate.Execution.Configuration;
using System;
using Limbo.Subscriptions.Extensions;
using Microsoft.Extensions.Configuration;
using Umbraco.Cms.Core.DependencyInjection;
using Limbo.MailSystem.Extensions;

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
        /// <param name="connectionStringKey"></param>
        /// <param name="dataAccessConfigurationSection"></param>
        /// <param name="mailConfigurationSection"></param>
        /// <param name="graphQLExtensions"></param>
        /// <returns></returns>
        public static IUmbracoBuilder AddSubscriptions(this IUmbracoBuilder builder, IConfiguration config, string connectionStringKey = "umbracoDbDSN", string dataAccessConfigurationSection = "Limbo.DataAccess", string mailConfigurationSection = "Limbo:MailSettings", Func<IRequestExecutorBuilder, IRequestExecutorBuilder>? graphQLExtensions = null) {
            builder.Services.AddSubscriptions(config, connectionStringKey, dataAccessConfigurationSection, graphQLExtensions)
                .AddMailSystem(config, mailConfigurationSection);

            return builder;
        }
    }
}
