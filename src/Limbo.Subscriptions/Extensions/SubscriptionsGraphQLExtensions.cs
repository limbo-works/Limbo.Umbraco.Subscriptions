﻿using System;
using HotChocolate.Execution.Configuration;
using Limbo.Subscriptions.Bases.GraphQL.Mutations;
using Limbo.Subscriptions.Bases.GraphQL.Queries;
using Limbo.Subscriptions.Categories.Mutations;
using Limbo.Subscriptions.Categories.Queries;
using Limbo.Subscriptions.NewsletterQueues.Mutations;
using Limbo.Subscriptions.NewsletterQueues.Queries;
using Limbo.Subscriptions.Subscribers.Mutations;
using Limbo.Subscriptions.Subscribers.Queries;
using Limbo.Subscriptions.SubscriptionItems.Mutations;
using Limbo.Subscriptions.SubscriptionItems.Queries;
using Limbo.Subscriptions.SubscriptionSystems.Mutations;
using Limbo.Subscriptions.SubscriptionSystems.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Extensions {
    /// <inheritdoc/>
    public static class SubscriptionsGraphQLExtensions {

        /// <summary>
        /// Adds the subscription package GraphQL setup
        /// </summary>
        /// <param name="services"></param>
        /// <param name="graphQLExtensions"></param>
        /// <returns></returns>
        public static IServiceCollection AddSubscriptionsGraphQL(this IServiceCollection services, Func<IRequestExecutorBuilder, IRequestExecutorBuilder>? graphQLExtensions = null) {
            if (graphQLExtensions == null) {
                graphQLExtensions = builder => {
                    return builder.AddQueryType<Query>()
                        .AddTypeExtension<CategoryQueries>()
                        .AddTypeExtension<NewsletterQueueQueries>()
                        .AddTypeExtension<SubscriberQueries>()
                        .AddTypeExtension<SubscriptionItemQueries>()
                        .AddTypeExtension<SubscriptionSystemQueries>()
                        .AddMutationType<Mutation>()
                        .AddTypeExtension<CategoryMutations>()
                        .AddTypeExtension<SubscriberMutations>()
                        .AddTypeExtension<NewsletterQueueMutations>()
                        .AddTypeExtension<SubscriptionItemMutations>()
                        .AddTypeExtension<SubscriptionSystemMutations>();
                };
            }

            services
                .AddGraphQLServer()
                .AddAuthorization()
                .AddFiltering()
                .AddSorting()
                .AddProjections()
                .OnSchemaError(new((dc, ex) => {
                    throw ex;
                }))
                .AddGraphQLExtensions(graphQLExtensions);

            services
                .AddSubscriptionAutomapper();

            return services;
        }

        /// <summary>
        /// Adds extensions for GraphQL
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="graphQLExtensions"></param>
        /// <returns></returns>
        public static IRequestExecutorBuilder AddGraphQLExtensions(this IRequestExecutorBuilder builder, Func<IRequestExecutorBuilder, IRequestExecutorBuilder> graphQLExtensions) {
            builder = graphQLExtensions.Invoke(builder);

            return builder;
        }
    }
}