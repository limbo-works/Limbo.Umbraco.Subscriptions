using System.Threading;
using System.Threading.Tasks;
using Limbo.Umbraco.Subscriptions.Content.Events.Managers;
using Limbo.Umbraco.Subscriptions.Properties;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Models.Entities;
using Umbraco.Cms.Core.Notifications;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Saved {
    internal class ContentSavedNotificationHandler : INotificationAsyncHandler<ContentSavedNotification> {
        private readonly IContentNewsletterManager _contentNewsletterManager;

        public ContentSavedNotificationHandler(IContentNewsletterManager contentNewsletterManager) {
            _contentNewsletterManager = contentNewsletterManager;
        }

        public async Task HandleAsync(ContentSavedNotification notification, CancellationToken cancellationToken) {
            foreach (var contentItem in notification.SavedEntities) {
                if (contentItem.HasProperty(PropertyAliases.IncludeInNextNewsletterAlias)) {
                    var dirty = (IRememberBeingDirty) contentItem;
                    var isNew = dirty.WasPropertyDirty("Id");
                    if (isNew) {
                        var includeInNextNewsletterRaw = contentItem.GetValue(PropertyAliases.IncludeInNextNewsletterAlias);
                        if ((int) includeInNextNewsletterRaw == 1) {
                            await _contentNewsletterManager.AddToNewsLetter(contentItem);
                        }
                    }
                }
            }
        }
    }
}
