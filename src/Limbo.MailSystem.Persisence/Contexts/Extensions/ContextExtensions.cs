using Limbo.MailSystem.Persisence.Contexts.Extensions.Options;
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
        /// <param name="contextOptions"></param>
        /// <returns></returns>
        public static IServiceCollection AddContexts(this IServiceCollection services, ContextOptions contextOptions) {
            services.AddPooledDbContextFactory<MailContext>(options =>
                options.UseSqlServer(contextOptions.Configuration.GetConnectionString(contextOptions.ConnectionStringKey)));

            services.AddTransient<IMailContext>(x => {
                var factory = x.GetRequiredService<IDbContextFactory<MailContext>>();
                return factory.CreateDbContext();
            });

            var context = services.BuildServiceProvider().GetRequiredService<IMailContext>();
            context.Context.Database.Migrate();

            return services;
        }
    }
}
