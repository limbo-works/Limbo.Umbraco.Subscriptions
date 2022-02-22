using Limbo.MailSystem.Queue.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Queue.Extentions {
    public static class ServiceExtentions {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddTransient<IQueueService, QueueService>();

            return services;
        }
    }
}
