using Limbo.Subscriptions.Persistence.Extentions;
using Limbo.Subscriptions.Bases.Automapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.DependencyInjection;

namespace Limbo.Subscriptions.Extentions {
    public static class SubscriptionsExtentions {
        public static IUmbracoBuilder AddSubscriptions(this IUmbracoBuilder builder, IConfiguration config, string connectionStringKey = "umbracoDbDSN", bool useSecurity = false) {
            builder.Services
                .AddPersistence(config, connectionStringKey)
                .AddSubscriptionServices()
                .AddSubscriptionsGraphQL(useSecurity);

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

        public static IServiceCollection AddSubscriptionAutomapper(this IServiceCollection services) {
            services
                .AddAutoMapper(typeof(AutomapperReference));

            return services;
        }
    }
}
