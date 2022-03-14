using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Persisence.MailSegments.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class MailSegmentExtensions {
        /// <summary>
        /// Adds mail segments
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddMailSegments(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
