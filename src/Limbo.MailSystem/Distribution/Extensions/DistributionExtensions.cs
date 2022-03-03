using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Distribution.Extensions {
    public static class DistributionExtensions {
        public static IServiceCollection AddDistributions(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
