using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Templates.RazorTemplates.Extensions {
    public static class RazorTemplateExtensions {
        public static IServiceCollection AddRazorTemplates(this IServiceCollection services) {
            services
                .AddBuilders();

            return services;
        }
    }
}
