using Limbo.MailSystem.Settings.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Settings.Extentions {
    public static class SettingsExtentions {
        /// <summary>
        /// Adds settings
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="configurationSection"></param>
        /// <returns></returns>
        public static IServiceCollection AddSettings(this IServiceCollection services, IConfiguration configuration, string configurationSection) {
            var mailSettings = new MailSettings();
            configuration.Bind(configurationSection, mailSettings);
            services.AddSingleton(mailSettings);

            return services;
        }
    }
}
