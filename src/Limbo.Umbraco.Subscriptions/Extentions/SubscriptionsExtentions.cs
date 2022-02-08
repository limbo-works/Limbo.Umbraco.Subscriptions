using Limbo.Umbraco.Subscription.Persistence.Extentions;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL;
using Limbo.Umbraco.Subscriptions.Categories.Extentions;
using Limbo.Umbraco.Subscriptions.Categories.Queries;
using Limbo.Umbraco.Subscriptions.NewsletterQueues.Extentions;
using Limbo.Umbraco.Subscriptions.NewsletterQueues.Queries;
using Limbo.Umbraco.Subscriptions.Subscribers.Extentions;
using Limbo.Umbraco.Subscriptions.Subscribers.Queries;
using Limbo.Umbraco.Subscriptions.SubscriptionItems.Extentions;
using Limbo.Umbraco.Subscriptions.SubscriptionItems.Queries;
using Limbo.Umbraco.Subscriptions.SubscriptionSystems.Extentions;
using Limbo.Umbraco.Subscriptions.SubscriptionSystems.Queries;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.Extentions {
    public static class SubscriptionsExtentions {
        public static IUmbracoBuilder AddSubscriptions(this IUmbracoBuilder builder, IConfiguration config) {
            builder.Services
                .AddPersistence(config)
                .AddSubscriptionServices()
                .AddSubscriptionsGraphQL();

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

        public static IServiceCollection AddSubscriptionsGraphQL(this IServiceCollection services) {
            services
                .AddGraphQLServer()
                .AddFiltering()
                .AddSorting()
                .OnSchemaError(new((dc, ex) => {
                    throw ex;
                }))
                .AddQueryType<Query>()
                .AddTypeExtension<CategoryQueries>()
                .AddTypeExtension<NewsletterQueueQueries>()
                .AddTypeExtension<SubscriberQueries>()
                .AddTypeExtension<SubscriptionItemQueries>()
                .AddTypeExtension<SubscriptionSystemQueries>();

            return services;
        }

        public static IApplicationBuilder UseSubscriptionsGraphQLEndpoint(this IApplicationBuilder app) {
            app.UseRouting();

            app.UseCors();

            app.UseEndpoints(endpoints => {
                endpoints.MapGraphQL();
            });

            return app;
        }
    }
}
