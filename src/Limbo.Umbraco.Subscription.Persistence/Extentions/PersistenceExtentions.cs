﻿using Limbo.Umbraco.Subscription.Persistence.Categories.Extentions;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Extentions;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Extentions;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Extentions;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Extentions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscription.Persistence.Extentions {
    public static class PersistenceExtentions {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration config) {
            services.AddDbContext<SubscriptionDbContext>(options => {
                options.UseSqlServer(config.GetConnectionString("umbracoDbDSN"));
            });

            services.AddScoped<ISubscriptionDbContext, SubscriptionDbContext>();

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