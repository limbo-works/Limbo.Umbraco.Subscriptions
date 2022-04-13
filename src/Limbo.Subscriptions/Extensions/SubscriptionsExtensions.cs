using Limbo.Subscriptions.Persistence.Extensions;
using Limbo.Subscriptions.Bases.Automapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HotChocolate.Execution.Configuration;
using System;
using Limbo.MailSystem.Extensions;

namespace Limbo.Subscriptions.Extensions {
    /// <inheritdoc/>
    public static class SubscriptionsExtensions {

        /// <summary>
        /// Adds subscription
        /// </summary>
        /// <param name="services"></param>
        /// <param name="config"></param>
        /// <param name="connectionStringKey"></param>
        /// <param name="dataAccessConfigurationSection"></param>
        /// <param name="graphQLExtensions"></param>
        /// <param name="mailConfigurationSection"></param>
        /// <returns></returns>
        public static IServiceCollection AddSubscriptions(this IServiceCollection services, IConfiguration config, string connectionStringKey = "Default", string dataAccessConfigurationSection = "Limbo:DataAccess", Func<IRequestExecutorBuilder, IRequestExecutorBuilder>? graphQLExtensions = null, string mailConfigurationSection = "Limbo:MailSystem") {
            services
                .AddPersistence(config, connectionStringKey, dataAccessConfigurationSection)
                .AddSubscriptionServices()
                .AddSubscriptionsGraphQL(graphQLExtensions)
                .AddMailSystem(config, connectionStringKey, mailConfigurationSection);

            return services;
        }

        /// <summary>
        /// Adds a graphql endpoint
        /// </summary>
        /// <param name="app"></param>
        /// <param name="useSecurity"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseSubscriptionsGraphQLEndpoint(this IApplicationBuilder app, bool useSecurity = true) {
            app.UseRouting();
            app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

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

        /// <summary>
        /// Adds automapper setup
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSubscriptionAutomapper(this IServiceCollection services) {
            services
                .AddAutoMapper(typeof(AutomapperReference));

            return services;
        }
    }
}
