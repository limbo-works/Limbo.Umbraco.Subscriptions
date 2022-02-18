﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.ApiClaims.Extentions {
    public static class ApiClaimExtentions {
        public static IServiceCollection AddApiClaims(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}