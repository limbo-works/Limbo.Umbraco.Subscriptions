using Limbo.MailSystem.TemplateBuilders.SimpleText.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.TemplateBuilders.SimpleText.Extensions {
    public static class BuilderExtensions {
        public static IServiceCollection AddBuilders(this IServiceCollection services) {
            services
                .AddScoped<ISimpleTextBuilder, SimpleTextBuilder>();

            return services;
        }
    }
}
