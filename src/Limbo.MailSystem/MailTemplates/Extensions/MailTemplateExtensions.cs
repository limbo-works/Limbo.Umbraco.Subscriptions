using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.MailTemplates.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class MailTemplateExtensions {
        /// <summary>
        /// Adds mail templates
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddMailTemplates(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
