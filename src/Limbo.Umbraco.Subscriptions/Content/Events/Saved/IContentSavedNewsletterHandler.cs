using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Saved {
    /// <summary>
    /// A handler used when content is saved
    /// </summary>
    public interface IContentSavedNewsletterHandler {

        /// <summary>
        /// Called when notification is sent
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task HandleAsync(IEnumerable<IContent> entities, CancellationToken cancellationToken);
    }
}