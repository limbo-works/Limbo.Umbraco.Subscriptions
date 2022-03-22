﻿using Limbo.Subscriptions.SubscriptionSystems.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.SubscriptionSystems.Extensions {
    public static class ServiceExtensions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<ISubscriptionSystemService, SubscriptionSystemService>();

            return services;
        }
    }
}