﻿using Limbo.Umbraco.Subscriptions.SubscriptionItems.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.SubscriptionItems.Extentions {
    public static class ServiceExtentions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<ISubscriptionItemService, SubscriptionItemService>();

            return services;
        }
    }
}
