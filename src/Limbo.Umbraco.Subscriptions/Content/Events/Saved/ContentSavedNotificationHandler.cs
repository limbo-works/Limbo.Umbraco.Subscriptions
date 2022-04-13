using System.Threading;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Saved {
    internal class ContentSavedNotificationHandler : INotificationAsyncHandler<ContentSavedNotification> {
        private readonly IContentSavedNewsletterHandler _contentSavedNewsletterHandler;

        public ContentSavedNotificationHandler(IContentSavedNewsletterHandler contentNewsletterHandler) {
            _contentSavedNewsletterHandler = contentNewsletterHandler;
        }

        public virtual async Task HandleAsync(ContentSavedNotification notification, CancellationToken cancellationToken) {
            await _contentSavedNewsletterHandler.HandleAsync(notification.SavedEntities, cancellationToken);
        }

    }
}
