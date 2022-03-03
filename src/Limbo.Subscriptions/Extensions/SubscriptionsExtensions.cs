using Limbo.Subscriptions.Persistence.Extensions;
using Limbo.Subscriptions.Bases.Automapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HotChocolate.Execution.Configuration;
using System;

namespace Limbo.Subscriptions.Extensions {
    public static class SubscriptionsExtensions {
        public static IServiceCollection AddSubscriptions(this IServiceCollection services, IConfiguration config, string connectionStringKey = "Default", Func<IRequestExecutorBuilder, IRequestExecutorBuilder>? graphQLExtensions = null) {
            services
                .AddPersistence(config, connectionStringKey)
                .AddSubscriptionServices()
                .AddSubscriptionsGraphQL(graphQLExtensions);

            return services;
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
