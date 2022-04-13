using Limbo.MailSystem.Templates.RazorTemplates.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Templates.RazorTemplates.Extensions {
    /// <inheritdoc/>
    public static class BuilderExtensions {
        /// <summary>
        /// Adds builder services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddBuilders(this IServiceCollection services) {
            services
                .AddTransient<IRazorBuilder, RazorBuilder>();

            return services;
        }
    }
}
