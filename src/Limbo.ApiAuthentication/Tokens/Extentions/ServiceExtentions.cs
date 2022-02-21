using Limbo.ApiAuthentication.Tokens.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Tokens.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class ServiceExtentions {
        /// <summary>
        /// Adds services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
