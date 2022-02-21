using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Tokens.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class TokenExtentions {
        /// <summary>
        /// Adds tokens
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddTokens(this IServiceCollection services) {
            services
                .AddServices()
                .AddGenerators()
                .AddValidators();

            return services;
        }
    }
}
