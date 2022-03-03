using Limbo.Subscriptions.Persistence.Extensions;
using Limbo.Subscriptions.Bases.Automapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.DependencyInjection;

namespace Limbo.Subscriptions.Extensions {
    public static class SubscriptionsExtensions {
        public static IUmbracoBuilder AddSubscriptions(this IUmbracoBuilder builder, IConfiguration config, string connectionStringKey = "umbracoDbDSN") {
            builder.Services
                .AddPersistence(config, connectionStringKey)
                .AddSubscriptionServices()
                .AddSubscriptionsGraphQL();

            return builder;
        }

        public static IApplicationBuilder UseSubscriptionsGraphQLEndpoint(this IApplicationBuilder app, bool useSecurity = true) {
            app.UseRouting();
            app.UseCors();

            if (useSecurity) {
                app
                    .UseAuthentication()
                    .UseAuthorization();
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
