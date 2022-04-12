using Limbo.Umbraco.Subscriptions.Content.Events.Managers;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ManagerExtensions {
        /// <summary>
        /// Adds managers
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddManagers(this IServiceCollection services) {
            services
                .AddScoped<IContentNewsletterManager, ContentNewsletterManager>();

            return services;
        }
    }
}
