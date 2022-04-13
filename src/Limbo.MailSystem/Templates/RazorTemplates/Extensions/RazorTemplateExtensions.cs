using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Templates.RazorTemplates.Extensions {
    /// <inheritdoc/>
    public static class RazorTemplateExtensions {
        /// <summary>
        /// Adds services for razor templates
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRazorTemplates(this IServiceCollection services) {
            services
                .AddBuilders();

            return services;
        }
    }
}
