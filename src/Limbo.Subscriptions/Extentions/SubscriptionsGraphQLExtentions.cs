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
using Limbo.Subscriptions.Tokens.Queries;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Extentions {
    public static class SubscriptionsGraphQLExtentions {

        public static IServiceCollection AddSubscriptionsGraphQL(this IServiceCollection services, bool useSecurity) {
            services
                .AddGraphQLServer()
                .AddSubscriptionSecurity(useSecurity)
                .AddFiltering()
                .AddSorting()
                .AddProjections()
                .OnSchemaError(new((dc, ex) => {
                    throw ex;
                }))
                .AddQueryType<Query>()
                .AddTypeExtension<CategoryQueries>()
                .AddTypeExtension<NewsletterQueueQueries>()
                .AddTypeExtension<SubscriberQueries>()
                .AddTypeExtension<SubscriptionItemQueries>()
                .AddTypeExtension<SubscriptionSystemQueries>()
                .AddTypeExtension<TokenQueries>()
                .AddMutationType<Mutation>()
                .AddTypeExtension<CategoryMutations>()
                .AddTypeExtension<SubscriberMutations>()
                .AddTypeExtension<NewsletterQueueMutations>()
                .AddTypeExtension<SubscriptionItemMutations>()
                .AddTypeExtension<SubscriptionSystemMutations>();

            services
                .AddSubscriptionAutomapper();

            return services;
        }

        public static IApplicationBuilder UseSubscriptionGraphQLEndpointSecurity(this IApplicationBuilder app) {
            app
                .UseAuthentication()
                .UseAuthorization();

            return app;
        }

        public static IRequestExecutorBuilder AddSubscriptionSecurity(this IRequestExecutorBuilder builder, bool useSecurity) {
            if (useSecurity) {
                builder.AddAuthorization();
            }
            return builder;
        }
    }
}