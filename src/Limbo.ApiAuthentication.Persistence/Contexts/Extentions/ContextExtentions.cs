using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.Contexts.Extentions {
    public static class ContextExtentions {
        public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration configuration, string connectionStringKey) {
            services.AddPooledDbContextFactory<ApiAuthenticationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(connectionStringKey))
                .UseLazyLoadingProxies()
                .LogTo(Console.WriteLine));

            services.AddScoped<IApiAuthenticationContext>(x => {
                var factory = x.GetRequiredService<IDbContextFactory<ApiAuthenticationContext>>();
                return factory.CreateDbContext();
            });

            return services;
        }
    }
}
