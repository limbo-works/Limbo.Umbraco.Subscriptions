using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Saved {
    public interface IContentSavedNewsletterHandler {
        Task HandleAsync(IEnumerable<IContent> entities, CancellationToken cancellationToken);
    }
}