using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.Contexts.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class ContextExtentions {
        /// <summary>
        /// Adds contexts
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="connectionStringKey"></param>
        /// <returns></returns>
        public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration configuration, string connectionStringKey) {
            services.AddPooledDbContextFactory<ApiAuthenticationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(connectionStringKey))
                .UseLazyLoadingProxies());

            services.AddScoped<IApiAuthenticationContext>(x => {
                var factory = x.GetRequiredService<IDbContextFactory<ApiAuthenticationContext>>();
                return factory.CreateDbContext();
            });

            var context = services.BuildServiceProvider().GetService<IApiAuthenticationContext>();
            context.Context.Database.Migrate();

            return services;
        }
    }
}
