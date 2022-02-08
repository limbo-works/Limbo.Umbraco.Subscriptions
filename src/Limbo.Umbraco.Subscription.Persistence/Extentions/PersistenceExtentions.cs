using System;
using Limbo.Umbraco.Subscription.Persistence.Categories.Extentions;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Extentions;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Extentions;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Extentions;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Extentions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscription.Persistence.Extentions {
    public static class PersistenceExtentions {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration config) {
            services.AddPooledDbContextFactory<SubscriptionDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("umbracoDbDSN")).LogTo(Console.WriteLine));

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
