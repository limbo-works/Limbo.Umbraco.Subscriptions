using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Saving {
    /// <summary>
    /// A handler used when content is saving
    /// </summary>
    public interface IContentSavingNewsletterHandler {

        /// <summary>
        /// Called when the notification is sent out
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task HandleAsync(IEnumerable<IContent> entities, CancellationToken cancellationToken);
    }
}