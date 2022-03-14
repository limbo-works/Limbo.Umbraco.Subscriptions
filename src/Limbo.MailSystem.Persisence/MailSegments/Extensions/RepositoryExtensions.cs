using Limbo.MailSystem.Persisence.MailSegments.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Persisence.MailSegments.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class RepositoryExtensions {
        /// <summary>
        /// Adds repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddScoped<IMailSegmentRepository, MailSegmentRepository>();

            return services;
        }
    }
}
