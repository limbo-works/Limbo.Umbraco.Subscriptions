﻿using Limbo.Subscriptions.SubscriptionItems.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.SubscriptionItems.Extensions {
    public static class ServiceExtensions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddTransient<ISubscriptionItemService, SubscriptionItemService>();

            return services;
        }
    }
}
