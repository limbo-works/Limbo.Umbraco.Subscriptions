using Limbo.MailSystem.Distribution.Extensions;
using Limbo.MailSystem.MailSegments.Extensions;
using Limbo.MailSystem.MailTemplates.Extensions;
using Limbo.MailSystem.Persisence.Extensions;
using Limbo.MailSystem.Queue.Extensions;
using Limbo.MailSystem.SegmentTypes.Extensions;
using Limbo.MailSystem.Settings.Extensions;
using Limbo.MailSystem.Templates.RazorTemplates.Extensions;
using Limbo.MailSystem.Templates.SimpleText.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class MailSystemExtensions {
        /// <summary>
        /// Adds the mail system
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="connectionStringKey"></param>
        /// <param name="configurationSection"></param>
        /// <returns></returns>
        public static IServiceCollection AddMailSystem(this IServiceCollection services, IConfiguration configuration, string connectionStringKey = "Default", string configurationSection = "Limbo:MailSystem") {
            services
                .AddPersistence(configuration, connectionStringKey)
                .AddSettings(configuration, configurationSection)
                .AddDistributions()
                .AddQueues()
                .AddMailSegments()
                .AddMailTemplates()
                .AddSegmentTypes()
                .AddSimpleTextTemplates()
                .AddRazorTemplates();

            return services;
        }
    }
}
