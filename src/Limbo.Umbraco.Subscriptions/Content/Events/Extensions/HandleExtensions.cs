using Limbo.Umbraco.Subscriptions.Content.Events.Saved;
using Limbo.Umbraco.Subscriptions.Content.Events.Saving;
using Limbo.Umbraco.Subscriptions.Content.Events.SendingContent;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Extensions {
    /// <inheritdoc/>
    public static class HandleExtensions {
        /// <summary>
        /// Adds handle services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddHandles(this IServiceCollection services) {
            services
                .AddTransient<IContentSavedNewsletterHandler, ContentSavedNewsletterHandler>()
                .AddTransient<IContentSavingNewsletterHandler, ContentSavingNewsletterHandler>()
                .AddTransient<ISendingContentHandler, SendingContentHandler>();

            return services;
        }
    }
}
