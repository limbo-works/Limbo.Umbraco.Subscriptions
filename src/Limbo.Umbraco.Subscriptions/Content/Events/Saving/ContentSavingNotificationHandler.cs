using System.Threading;
using System.Threading.Tasks;
using Limbo.Umbraco.Subscriptions.Content.Events.Managers;
using Limbo.Umbraco.Subscriptions.Properties;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Saving {
    internal class ContentSavingNotificationHandler : INotificationAsyncHandler<ContentSavingNotification> {
        private readonly IContentNewsletterManager _contentNewsletterManager;

        public ContentSavingNotificationHandler(IContentNewsletterManager contentNewsletterManager) {
            _contentNewsletterManager = contentNewsletterManager;
        }

        public async Task HandleAsync(ContentSavingNotification notification, CancellationToken cancellationToken) {
            foreach (var contentItem in notification.SavedEntities) {
                if (contentItem.HasProperty(PropertyAliases.IncludeInNextNewsletterAlias)) {
                    var includeInNextNewsletterRaw = contentItem.GetValue(PropertyAliases.IncludeInNextNewsletterAlias);
                    bool isNew = contentItem.HasIdentity is false;
                    if (isNew) {
                        continue;
                    } else if ((int) includeInNextNewsletterRaw == 1) {
                        await _contentNewsletterManager.AddToNewsLetter(contentItem);
                    } else {
                        await _contentNewsletterManager.RemoveFromNewsletter(contentItem);
                    }
                }
            }
        }
    }
}
