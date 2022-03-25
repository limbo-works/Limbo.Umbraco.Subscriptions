﻿using Limbo.Subscriptions.Subscribers.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Subscribers.Extensions {
    public static class ServiceExtensions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddTransient<ISubscriberService, SubscriberService>();

            return services;
        }
    }
}
