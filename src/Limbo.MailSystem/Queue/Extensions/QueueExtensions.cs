using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Queue.Extensions {
    public static class QueueExtensions {
        public static IServiceCollection AddQueues(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
