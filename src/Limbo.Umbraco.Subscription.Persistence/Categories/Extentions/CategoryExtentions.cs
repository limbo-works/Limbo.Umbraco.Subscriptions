﻿using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscription.Persistence.Categories.Extentions {
    public static class CategoryExtentions {
        public static IServiceCollection AddCategories(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
