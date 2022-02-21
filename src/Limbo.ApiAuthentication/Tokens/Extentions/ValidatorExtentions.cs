using Limbo.ApiAuthentication.Tokens.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Tokens.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class ValidatorExtentions {
        /// <summary>
        /// Adds validators
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddValidators(this IServiceCollection services) {
            services
                .AddScoped<IRefreshTokenValidator, RefreshTokenValidator>();

            return services;
        }
    }
}
