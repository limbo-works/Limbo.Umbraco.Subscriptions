using Limbo.ApiAuthentication.Tokens.Generators;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Tokens.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class GeneratorExtentions {
        /// <summary>
        /// Adds generators
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddGenerators(this IServiceCollection services) {
            services
                .AddScoped<ITokenGenerator, TokenGenerator>();

            return services;
        }
    }
}
