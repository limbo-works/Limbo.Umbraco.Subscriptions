using Limbo.MailSystem.Distribution.Extensions;
using Limbo.MailSystem.Queue.Extensions;
using Limbo.MailSystem.Settings.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class MailSystemExtensions {
        /// <summary>
        /// Adds the mail system
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="configurationSection"></param>
        /// <returns></returns>
        public static IServiceCollection AddMailSystem(this IServiceCollection services, IConfiguration configuration, string configurationSection = "Limbo:MailSystem") {
            services
                .AddSettings(configuration, configurationSection)
                .AddDistributions()
                .AddQueues();

            return services;
        }
    }
}
