using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.Templates.SimpleText.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class SimpleTextExtensions {
        /// <summary>
        /// Adds simple text templates
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSimpleTextTemplates(this IServiceCollection services) {
            services
                .AddBuilders()
                .AddServices();

            return services;
        }
    }
}
