using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Limbo.Umbraco.Subscriptions.Content.Events.Managers;
using Limbo.Umbraco.Subscriptions.Properties;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.Entities;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Saved {
    public class ContentSavedNewsletterHandler : IContentSavedNewsletterHandler {
        private readonly IContentNewsletterManager _contentNewsletterManager;

        public ContentSavedNewsletterHandler(IContentNewsletterManager contentNewsletterManager) {
            _contentNewsletterManager = contentNewsletterManager;
        }

        public virtual async Task HandleAsync(IEnumerable<IContent> entities, CancellationToken cancellationToken) {
            foreach (var contentItem in entities) {
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
