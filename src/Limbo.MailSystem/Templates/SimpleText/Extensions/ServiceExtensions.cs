using Limbo.MailSystem.Templates.SimpleText.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Templates.SimpleText.Extensions {
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
                .AddScoped<ISimpleTextService, SimpleTextService>();

            return services;
        }
    }
}
