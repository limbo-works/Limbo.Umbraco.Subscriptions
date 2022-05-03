using Limbo.MailSystem.Persistence.SegmentTypes.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Persistence.SegmentTypes.Extensions {
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
                .AddScoped<ISegmentTypeRepository, SegmentTypeRepository>();

            return services;
        }
    }
}
