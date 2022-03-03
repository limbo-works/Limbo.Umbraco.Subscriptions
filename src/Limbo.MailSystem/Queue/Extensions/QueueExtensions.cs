using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Queue.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class QueueExtensions {
        /// <summary>
        /// Adds queues
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddQueues(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
