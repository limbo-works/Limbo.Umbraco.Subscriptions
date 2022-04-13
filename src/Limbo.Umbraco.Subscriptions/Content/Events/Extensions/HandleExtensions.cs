using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Limbo.Umbraco.Subscriptions.Content.Events.Saved;
using Limbo.Umbraco.Subscriptions.Content.Events.Saving;
using Limbo.Umbraco.Subscriptions.Content.Events.SendingContent;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Extensions {
    public static class HandleExtensions {
        public static IServiceCollection AddHandles(this IServiceCollection services) {
            services
                .AddTransient<IContentSavedNewsletterHandler, ContentSavedNewsletterHandler>()
                .AddTransient<IContentSavingNewsletterHandler, ContentSavingNewsletterHandler>()
                .AddTransient<ISendingContentHandler, SendingContentHandler>();

            return services;
        }
    }
}
