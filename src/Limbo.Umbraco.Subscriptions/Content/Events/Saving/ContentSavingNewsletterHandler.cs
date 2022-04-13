using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Limbo.Umbraco.Subscriptions.Content.Events.Managers;
using Limbo.Umbraco.Subscriptions.Properties;
using Umbraco.Cms.Core.Models;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Saving {
    /// <inheritdoc/>
    public class ContentSavingNewsletterHandler : IContentSavingNewsletterHandler {
        private readonly IContentNewsletterManager _contentNewsletterManager;

        /// <inheritdoc/>
        public ContentSavingNewsletterHandler(IContentNewsletterManager contentNewsletterManager) {
            _contentNewsletterManager = contentNewsletterManager;
        }

        /// <inheritdoc/>
        public virtual async Task HandleAsync(IEnumerable<IContent> entities, CancellationToken cancellationToken) {
            foreach (var contentItem in entities) {
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
