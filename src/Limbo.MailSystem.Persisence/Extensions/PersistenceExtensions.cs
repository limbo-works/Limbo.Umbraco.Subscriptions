using Limbo.MailSystem.Persisence.Contexts.Extensions;
using Limbo.MailSystem.Persisence.MailSegments.Extensions;
using Limbo.MailSystem.Persisence.MailTemplates.Extensions;
using Limbo.MailSystem.Persisence.SegmentTypes.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Persisence.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class PersistenceExtensions {
        /// <summary>
        /// Adds the persistence services
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="connectionStringKey"></param>
        /// <returns></returns>
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration, string connectionStringKey) {
            services
                .AddContexts(configuration, connectionStringKey)
                .AddMailTemplates()
                .AddMailSegments()
                .AddSegmentTypes();

            return services;
        }
    }
}
