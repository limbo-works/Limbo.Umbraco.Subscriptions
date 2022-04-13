using System.Threading;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Saving {
    internal class ContentSavingNotificationHandler : INotificationAsyncHandler<ContentSavingNotification> {
        private readonly IContentSavingNewsletterHandler _contentSavingNewsletterHandler;

        public ContentSavingNotificationHandler(IContentSavingNewsletterHandler contentSavingNewsletterHandler) {
            _contentSavingNewsletterHandler = contentSavingNewsletterHandler;
        }

        public virtual async Task HandleAsync(ContentSavingNotification notification, CancellationToken cancellationToken) {
            await _contentSavingNewsletterHandler.HandleAsync(notification.SavedEntities, cancellationToken);
        }

    }
}
