﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Contexts.Extensions {
    public static class ContextExtensions {
        public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration configuration, string connectionStringKey) {
            services.AddPooledDbContextFactory<SubscriptionDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(connectionStringKey))
                .UseLazyLoadingProxies());

            services.AddScoped<ISubscriptionDbContext>(x => {
                var factory = x.GetRequiredService<IDbContextFactory<SubscriptionDbContext>>();
                return factory.CreateDbContext();
            });

            var context = services.BuildServiceProvider().GetRequiredService<ISubscriptionDbContext>();
            context.Context.Database.Migrate();

            return services;
        }
    }
}
