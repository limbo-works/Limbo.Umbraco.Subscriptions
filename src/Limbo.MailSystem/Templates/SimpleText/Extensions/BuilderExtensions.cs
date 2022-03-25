using Limbo.MailSystem.Templates.SimpleText.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Templates.SimpleText.Extensions {
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
                .AddTransient<ISimpleTextBuilder, SimpleTextBuilder>();

            return services;
        }
    }
}
