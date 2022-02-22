using Limbo.MailSystem.Distribution.Extentions;
using Limbo.MailSystem.Queue.Extentions;
using Limbo.MailSystem.Settings.Extentions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Extentions {
    public static class MailSystemExtentions {
        public static IServiceCollection AddMailSystem(this IServiceCollection services, IConfiguration configuration, string configurationSection = "Limbo:MailSystem") {
            services
                .AddSettings(configuration, configurationSection)
                .AddDistributions()
                .AddQueues();

            return services;
        }
    }
}
