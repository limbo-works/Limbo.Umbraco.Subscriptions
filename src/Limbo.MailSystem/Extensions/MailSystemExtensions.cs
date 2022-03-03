using Limbo.MailSystem.Distribution.Extensions;
using Limbo.MailSystem.Queue.Extensions;
using Limbo.MailSystem.Settings.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Extensions {
    public static class MailSystemExtensions {
        public static IServiceCollection AddMailSystem(this IServiceCollection services, IConfiguration configuration, string configurationSection = "Limbo:MailSystem") {
            services
                .AddSettings(configuration, configurationSection)
                .AddDistributions()
                .AddQueues();

            return services;
        }
    }
}
