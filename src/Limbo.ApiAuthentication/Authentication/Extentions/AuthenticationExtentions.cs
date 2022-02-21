using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Authentication.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class AuthenticationExtentions {
        /// <summary>
        /// Adds authentication services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddAuthenticationServices(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
