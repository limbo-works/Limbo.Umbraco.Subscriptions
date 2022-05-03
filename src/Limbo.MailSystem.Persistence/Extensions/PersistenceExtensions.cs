using Limbo.MailSystem.Persistence.Contexts.Extensions;
using Limbo.MailSystem.Persistence.Extensions.Options;
using Limbo.MailSystem.Persistence.MailSegments.Extensions;
using Limbo.MailSystem.Persistence.MailTemplates.Extensions;
using Limbo.MailSystem.Persistence.SegmentTypes.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Persistence.Extensions {
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
