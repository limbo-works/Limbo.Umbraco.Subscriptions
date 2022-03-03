using Limbo.MailSystem.Queue.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Queue.Extensions {
    public static class ServiceExtensions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddTransient<IQueueService, QueueService>();

            return services;
        }
    }
}
