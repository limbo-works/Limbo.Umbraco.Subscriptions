using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Persisence.SegmentTypes.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class SegmentTypeExtensions {
        /// <summary>
        /// Adds segment types
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSegmentTypes(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
