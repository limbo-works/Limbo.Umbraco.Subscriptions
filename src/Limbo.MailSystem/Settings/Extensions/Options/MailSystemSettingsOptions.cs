using Microsoft.Extensions.Configuration;

namespace Limbo.MailSystem.Settings.Extensions.Options {
    /// <summary>
    /// Options for the mail system settings
    /// </summary>
    public class MailSystemSettingsOptions {
        /// <summary>
        /// The app configuration
        /// </summary>
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// The configruation section to get the settings from. Default is "Limbo:MailSystem"
        /// </summary>
        public string ConfigurationSection { get; set; } = "Limbo:MailSystem";

        /// <inheritdoc/>
        public MailSystemSettingsOptions(IConfiguration configuration) {
            Configuration = configuration;
        }
    }
}
