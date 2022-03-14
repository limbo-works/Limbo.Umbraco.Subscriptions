using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Persisence.Contexts.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ContextExtensions {

        /// <summary>
        /// Adds contexts
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="connectionStringKey"></param>
        /// <returns></returns>
        public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration configuration, string connectionStringKey) {
            services.AddPooledDbContextFactory<MailContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(connectionStringKey))
                .UseLazyLoadingProxies());

            services.AddScoped<IMailContext>(x => {
                var factory = x.GetRequiredService<IDbContextFactory<MailContext>>();
                return factory.CreateDbContext();
            });

            var context = services.BuildServiceProvider().GetRequiredService<IMailContext>();
            context.Context.Database.Migrate();

            return services;
        }
    }
}
