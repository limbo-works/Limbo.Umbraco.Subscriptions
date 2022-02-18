using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Contexts.Extentions {
    public static class ContextExtentions {
        public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration configuration, string connectionStringKey) {
            services.AddPooledDbContextFactory<SubscriptionDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(connectionStringKey))
                .UseLazyLoadingProxies()
                .LogTo(Console.WriteLine));

            services.AddScoped<ISubscriptionDbContext>(x => {
                var factory = x.GetRequiredService<IDbContextFactory<SubscriptionDbContext>>();
                return factory.CreateDbContext();
            });

            return services;
        }
    }
}
