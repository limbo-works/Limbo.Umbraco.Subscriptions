using Limbo.MailSystem.TemplateBuilders.SimpleText.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.MailSystem.TemplateBuilders.SimpleText.Extentions {
    public static class BuilderExtentions {
        public static IServiceCollection AddBuilders(this IServiceCollection services) {
            services
                .AddScoped<ISimpleTextBuilder, SimpleTextBuilder>();

            return services;
        }
    }
}
