using Limbo.MailSystem.Queue.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Queue.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ServiceExtensions {
        /// <summary>
        /// Adds services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddTransient<IQueueService, QueueService>();

            return services;
        }
    }
}
