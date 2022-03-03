using HotChocolate.Execution.Configuration;
using System;
using Limbo.Subscriptions.Extensions;
using Microsoft.Extensions.Configuration;
using Umbraco.Cms.Core.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.Extensions {
    public static class SubscriptionsExtensions {
        public static IUmbracoBuilder AddSubscriptions(this IUmbracoBuilder builder, IConfiguration config, string connectionStringKey = "umbracoDbDSN", Func<IRequestExecutorBuilder, IRequestExecutorBuilder>? graphQLExtensions = null) {
            builder.Services.AddSubscriptions(config, connectionStringKey, graphQLExtensions);

            return builder;
        }
    }
}
