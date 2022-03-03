using HotChocolate.Execution.Configuration;
using System;
using Limbo.Subscriptions.Extensions;
using Microsoft.Extensions.Configuration;
using Umbraco.Cms.Core.DependencyInjection;

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
        /// <param name="graphQLExtensions"></param>
        /// <returns></returns>
        public static IUmbracoBuilder AddSubscriptions(this IUmbracoBuilder builder, IConfiguration config, string connectionStringKey = "umbracoDbDSN", Func<IRequestExecutorBuilder, IRequestExecutorBuilder>? graphQLExtensions = null) {
            builder.Services.AddSubscriptions(config, connectionStringKey, graphQLExtensions);

            return builder;
        }
    }
}
