using Limbo.MailSystem.Persisence.Contexts.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace Limbo.MailSystem.Persisence.Extensions.Options {
    /// <summary>
    /// Options for the mail systems persistence options
    /// </summary>
    public class MailSystemPersistenceOptions {

        /// <summary>
        /// Options for the context
        /// </summary>
        public ContextOptions ContextOptions { get; set; }

        /// <inheritdoc/>
        public MailSystemPersistenceOptions(IConfiguration configuration) {
            ContextOptions = new(configuration);
        }
    }
}
