using Limbo.MailSystem.Templates.RazorTemplates.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Templates.RazorTemplates.Extensions {
    public static class BuilderExtensions {
        public static IServiceCollection AddBuilders(this IServiceCollection services) {
            services
                .AddTransient<IRazorBuilder, RazorBuilder>();

            return services;
        }
    }
}
