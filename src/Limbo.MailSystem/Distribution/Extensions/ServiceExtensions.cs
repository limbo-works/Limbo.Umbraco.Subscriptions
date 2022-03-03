using Limbo.MailSystem.Distribution.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Distribution.Extensions {
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
                .AddSingleton<IEmailDistributorService, EmailDistributorService>();

            return services;
        }
    }
}
