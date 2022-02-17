using HotChocolate.Execution.Configuration;
using Limbo.Subscriptions.Persistence.Extentions;
using Limbo.Subscriptions.Bases.Automapper;
using Limbo.Subscriptions.Bases.GraphQL.Mutations;
using Limbo.Subscriptions.Bases.GraphQL.Queries;
using Limbo.Subscriptions.Categories.Extentions;
using Limbo.Subscriptions.Categories.Mutations;
using Limbo.Subscriptions.Categories.Queries;
using Limbo.Subscriptions.NewsletterQueues.Extentions;
using Limbo.Subscriptions.NewsletterQueues.Mutations;
using Limbo.Subscriptions.NewsletterQueues.Queries;
using Limbo.Subscriptions.Subscribers.Extentions;
using Limbo.Subscriptions.Subscribers.Mutations;
using Limbo.Subscriptions.Subscribers.Queries;
using Limbo.Subscriptions.SubscriptionItems.Extentions;
using Limbo.Subscriptions.SubscriptionItems.Mutations;
using Limbo.Subscriptions.SubscriptionItems.Queries;
using Limbo.Subscriptions.SubscriptionSystems.Extentions;
using Limbo.Subscriptions.SubscriptionSystems.Mutations;
using Limbo.Subscriptions.SubscriptionSystems.Queries;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.DependencyInjection;
using Limbo.Subscriptions.Tokens.Queries;

namespace Limbo.Subscriptions.Extentions {
    public static class SubscriptionsExtentions {
        public static IUmbracoBuilder AddSubscriptions(this IUmbracoBuilder builder, IConfiguration config, bool useSecurity = false) {
            builder.Services
                .AddPersistence(config)
                .AddSubscriptionServices()
                .AddSubscriptionsGraphQL(useSecurity);

            return builder;
        }

        public static IServiceCollection AddSubscriptionServices(this IServiceCollection services) {
            services
                .AddCategories()
                .AddNewsletterQueues()
                .AddSubscribers()
                .AddSubscribtionItems()
                .AddSubscriptionSystems();

            return services;
        }

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

        public static IRequestExecutorBuilder AddSubscriptionSecurity(this IRequestExecutorBuilder builder, bool useSecurity) {
            if (useSecurity) {
                builder.AddAuthorization();
            }
            return builder;
        }

        public static IApplicationBuilder UseSubscriptionsGraphQLEndpoint(this IApplicationBuilder app, bool useSecurity = false) {
            app.UseRouting();
            app.UseCors();

            if (useSecurity) {
                app.UseSubscriptionGraphQLEndpointSecurity();
            }

            app.UseEndpoints(endpoints => {
                endpoints.MapGraphQL();
            });

            return app;
        }

        public static IApplicationBuilder UseSubscriptionGraphQLEndpointSecurity(this IApplicationBuilder app) {
            app
                .UseAuthentication()
                .UseAuthorization();

            return app;
        }

        public static IServiceCollection AddSubscriptionAutomapper(this IServiceCollection services) {
            services
                .AddAutoMapper(typeof(AutomapperReference));

            return services;
        }
    }
}
