﻿using Limbo.MailSystem.Persistence.MailTemplates.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Persistence.MailTemplates.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class RepositoryExtensions {
        /// <summary>
        /// Adds repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<IMailTemplateRepository, MailTemplateRepository>();

            return services;
        }
    }
}
