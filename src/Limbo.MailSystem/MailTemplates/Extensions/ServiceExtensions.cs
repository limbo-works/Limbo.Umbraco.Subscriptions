using Limbo.MailSystem.MailTemplates.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.MailTemplates.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ServiceExtensions {
        /// <summary>
        /// Adds services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<IMailTemplateService, MailTemplateService>();

            return services;
        }
    }
}
