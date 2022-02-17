using System;
using Limbo.Subscriptions.Persistence.Categories.Extentions;
using Limbo.Subscriptions.Persistence.Contexts;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Extentions;
using Limbo.Subscriptions.Persistence.Subscribers.Extentions;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Extentions;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Extentions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Extentions {
    public static class PersistenceExtentions {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration config) {
            services.AddPooledDbContextFactory<SubscriptionDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("umbracoDbDSN"))
                .UseLazyLoadingProxies()
                .LogTo(Console.WriteLine));

            services.AddScoped<ISubscriptionDbContext>(x => {
                var factory = x.GetRequiredService<IDbContextFactory<SubscriptionDbContext>>();
                return factory.CreateDbContext();
            });

            services
                .AddCategories()
                .AddNewsletterQueues()
                .AddSubscribers()
                .AddSubcriptionItems()
                .AddSubscriptionSystems();

            return services;
        }
    }
}
