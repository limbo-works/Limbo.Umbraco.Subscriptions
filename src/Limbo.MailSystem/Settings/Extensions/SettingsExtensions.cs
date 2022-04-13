using Limbo.MailSystem.Settings.Extensions.Options;
using Limbo.MailSystem.Settings.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Settings.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class SettingsExtensions {
        /// <summary>
        /// Adds settings
        /// </summary>
        /// <param name="services"></param>
        /// <param name="mailSystemSettingsOptions"></param>
        /// <returns></returns>
        public static IServiceCollection AddSettings(this IServiceCollection services, MailSystemSettingsOptions mailSystemSettingsOptions) {
            var mailSettings = new MailSettings();
            mailSystemSettingsOptions.Configuration.Bind(mailSystemSettingsOptions.ConfigurationSection, mailSettings);
            services.AddSingleton(mailSettings);

            return services;
        }
    }
}
