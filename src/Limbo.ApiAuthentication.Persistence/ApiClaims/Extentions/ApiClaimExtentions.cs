using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Extentions {
    public static class ApiClaimExtentions {
        public static IServiceCollection AddApiClaims(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
