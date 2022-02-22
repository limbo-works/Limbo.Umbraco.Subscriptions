using Limbo.MailSystem.Distribution.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Distribution.Extentions {
    public static class ServiceExtentions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddSingleton<IEmailDistributorService, EmailDistributorService>();

            return services;
        }
    }
}
