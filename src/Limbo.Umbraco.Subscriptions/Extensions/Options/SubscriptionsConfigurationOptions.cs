using Limbo.Subscriptions.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace Limbo.Umbraco.Subscriptions.Extensions.Options {
    /// <summary>
    /// Options
    /// </summary>
    public class SubscriptionsConfigurationOptions {

        /// <summary>
        /// Options for subscriptions
        /// </summary>
        public SubscriptionOptions SubscriptionOptions { get; set; }

        /// <inheritdoc/>
        public SubscriptionsConfigurationOptions(IConfiguration configuration) {
            SubscriptionOptions = new(configuration);
        }
    }
}
