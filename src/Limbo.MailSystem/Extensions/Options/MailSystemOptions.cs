using Limbo.MailSystem.Persistence.Extensions.Options;
using Limbo.MailSystem.Settings.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace Limbo.MailSystem.Extensions.Options {
    /// <summary>
    /// Options for mail the mail system
    /// </summary>
    public class MailSystemOptions {
        /// <summary>
        /// Options for the mail system persistence layer
        /// </summary>
        public MailSystemPersistenceOptions MailSystemPersistenceOptions { get; set; }

        /// <summary>
        /// Options for the mail system settings
        /// </summary>
        public MailSystemSettingsOptions MailSystemSettingsOptions { get; set; }

        /// <inheritdoc/>
        public MailSystemOptions(IConfiguration configuration) {
            MailSystemPersistenceOptions = new(configuration);
            MailSystemSettingsOptions = new(configuration);
        }
    }
}
