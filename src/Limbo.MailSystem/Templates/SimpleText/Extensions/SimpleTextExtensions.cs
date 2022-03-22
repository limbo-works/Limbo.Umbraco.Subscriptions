using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Templates.SimpleText.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class SimpleTextExtensions {
        /// <summary>
        /// Adds simple text templates
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSimpleTextTemplates(this IServiceCollection services) {
            services
                .AddBuilders()
                .AddServices();

            return services;
        }
    }
}
