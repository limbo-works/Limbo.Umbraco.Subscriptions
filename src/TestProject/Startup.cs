using Limbo.ApiAuthentication.Extensions;
using Limbo.ApiAuthentication.Extensions.Models;
using Limbo.ApiAuthentication.Settings.Models;
using Limbo.Subscriptions.Extensions;
using Limbo.Subscriptions.Extensions.Options;
using Limbo.Umbraco.Subscriptions.Content.Events.Managers;
using Limbo.Umbraco.Subscriptions.Content.Events.Saved;
using Limbo.Umbraco.Subscriptions.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Models;
using Umbraco.Extensions;

namespace TestProject {
    public class Startup {
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _config;

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup" /> class.
        /// </summary>
        /// <param name="webHostEnvironment">The web hosting environment.</param>
        /// <param name="config">The configuration.</param>
        /// <remarks>
        /// Only a few services are possible to be injected here https://github.com/dotnet/aspnetcore/issues/9337
        /// </remarks>
        public Startup(IWebHostEnvironment webHostEnvironment, IConfiguration config) {
            _env = webHostEnvironment ?? throw new ArgumentNullException(nameof(webHostEnvironment));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <remarks>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        /// </remarks>
        public void ConfigureServices(IServiceCollection services) {


            services.AddUmbraco(_env, _config)
                .AddBackOffice()
                .AddWebsite()
                .AddComposers()
                .AddSubscriptions(_config, options => { })
                .Build();
            services
                .AddTransient<IContentSavedNewsletterHandler, Custom>();
            services
                .AddRazorTemplating();

            services.AddLimboApiAuthentication(_config, settings: new ApiAuthenticationConfigurationSettings() { ConnectionStringKey = "umbracoDbDSN" });
        }

        /// <summary>
        /// Configures the application.
        /// </summary>
        /// <param name="app">The application builder.</param>
        /// <param name="env">The web hosting environment.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApiAuthenticationSettings apiAuthenticationSettings) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseJwtDebug(apiAuthenticationSettings);

            app.UseSubscriptionsGraphQLEndpoint(new SubscriptionGraphQlEndpointOptions {
                UseSecurity = true
            });


            app.UseUmbraco()
                .WithMiddleware(u => {
                    u.UseBackOffice();
                    u.UseWebsite();
                })
                .WithEndpoints(u => {
                    u.UseInstallerEndpoints();
                    u.UseBackOfficeEndpoints();
                    u.UseWebsiteEndpoints();
                });
        }
    }

    internal class Custom : ContentSavedNewsletterHandler {
        public Custom(IContentNewsletterManager contentNewsletterManager) : base(contentNewsletterManager) {
        }

        public override Task HandleAsync(IEnumerable<IContent> entities, CancellationToken cancellationToken) {
            Console.WriteLine("Hello");
            return base.HandleAsync(entities, cancellationToken);
        }
    }
}
