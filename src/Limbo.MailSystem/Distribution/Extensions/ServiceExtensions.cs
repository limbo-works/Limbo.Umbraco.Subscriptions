using Limbo.MailSystem.Distribution.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Distribution.Extensions {
    public static class ServiceExtensions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddSingleton<IEmailDistributorService, EmailDistributorService>();

            return services;
        }
    }
}
