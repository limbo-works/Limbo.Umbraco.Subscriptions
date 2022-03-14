using Limbo.MailSystem.Persisence.MailTemplates.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Persisence.MailTemplates.Extensions {
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
