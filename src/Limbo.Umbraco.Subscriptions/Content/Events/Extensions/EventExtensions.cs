using Limbo.Umbraco.Subscriptions.Content.Events.Saved;
using Limbo.Umbraco.Subscriptions.Content.Events.Saving;
using Limbo.Umbraco.Subscriptions.Content.Events.SendingContent;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Notifications;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class EventExtensions {
        /// <summary>
        /// Adds events
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IUmbracoBuilder AddEvents(this IUmbracoBuilder builder) {
            builder
                .AddNotificationAsyncHandler<ContentSavingNotification, ContentSavingNotificationHandler>()
                .AddNotificationAsyncHandler<ContentSavedNotification, ContentSavedNotificationHandler>()
                .AddNotificationHandler<SendingContentNotification, SendingContentNotificationHandler>();

            builder.Services
                .AddManagers()
                .AddHandles();

            return builder;
        }
    }
}
