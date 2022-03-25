using Limbo.Umbraco.Subscriptions.Queues.Jobs.Recuring;
using Limbo.Umbraco.Subscriptions.Queues.Jobs.Recuring.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.Queues.Jobs.Extensions {
    public static class JobExtensions {
        public static IServiceCollection AddJobs(this IServiceCollection services) {
            services.AddHostedService<DistributeNewsletters>();
            var distributeNewsletterSettings = new DistributeNewsLettersSettings();
            services.AddSingleton(distributeNewsletterSettings);

            return services;
        }
    }
}
