using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Distribution.Extentions {
    public static class DistributionExtentions {
        public static IServiceCollection AddDistributions(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
