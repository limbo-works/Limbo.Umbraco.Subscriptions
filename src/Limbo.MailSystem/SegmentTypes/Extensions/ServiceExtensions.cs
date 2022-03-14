using Limbo.MailSystem.SegmentTypes.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.SegmentTypes.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ServiceExtensions {
        /// <summary>
        ///  Adds services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<ISegmentTypeService, SegmentTypeService>();

            return services;
        }
    }
}
