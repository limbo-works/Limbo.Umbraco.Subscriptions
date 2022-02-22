using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Queue.Extentions {
    public static class QueueExtentions {
        public static IServiceCollection AddQueues(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
