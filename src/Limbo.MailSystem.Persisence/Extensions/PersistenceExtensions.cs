using Limbo.MailSystem.Persisence.Contexts.Extensions;
using Limbo.MailSystem.Persisence.Extensions.Options;
using Limbo.MailSystem.Persisence.MailSegments.Extensions;
using Limbo.MailSystem.Persisence.MailTemplates.Extensions;
using Limbo.MailSystem.Persisence.SegmentTypes.Extensions;
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
        /// <param name="mailSystemPersistenceOptions"></param>
        /// <returns></returns>
        public static IServiceCollection AddPersistence(this IServiceCollection services, MailSystemPersistenceOptions mailSystemPersistenceOptions) {
            services
                .AddContexts(mailSystemPersistenceOptions.ContextOptions)
                .AddMailTemplates()
                .AddMailSegments()
                .AddSegmentTypes();

            return services;
        }
    }
}
