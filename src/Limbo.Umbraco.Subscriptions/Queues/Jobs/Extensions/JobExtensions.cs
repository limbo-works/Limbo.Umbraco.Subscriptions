using Limbo.Umbraco.Subscriptions.Queues.Jobs.Recuring;
using Limbo.Umbraco.Subscriptions.Queues.Jobs.Recuring.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.Queues.Jobs.Extensions {
    /// <inheritdoc/>
    public static class JobExtensions {
        /// <summary>
        /// Adds job services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddJobs(this IServiceCollection services) {
            services.AddHostedService<DistributeNewsletters>();
            var distributeNewsletterSettings = new DistributeNewsLettersSettings();
            services.AddSingleton(distributeNewsletterSettings);

            return services;
        }
    }
}
