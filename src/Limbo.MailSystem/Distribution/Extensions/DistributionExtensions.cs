using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Distribution.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class DistributionExtensions {
        /// <summary>
        /// Adds distributions
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDistributions(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
