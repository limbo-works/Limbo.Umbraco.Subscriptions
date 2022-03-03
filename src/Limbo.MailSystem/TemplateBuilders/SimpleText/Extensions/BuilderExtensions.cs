using Limbo.MailSystem.TemplateBuilders.SimpleText.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.TemplateBuilders.SimpleText.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class BuilderExtensions {
        /// <summary>
        /// Adds builders
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddBuilders(this IServiceCollection services) {
            services
                .AddScoped<ISimpleTextBuilder, SimpleTextBuilder>();

            return services;
        }
    }
}
