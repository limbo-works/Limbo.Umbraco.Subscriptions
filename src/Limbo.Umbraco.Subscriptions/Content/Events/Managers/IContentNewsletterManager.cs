using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Managers {
    /// <summary>
    /// A manager for adding content to newsletter queues
    /// </summary>
    public interface IContentNewsletterManager {

        /// <summary>
        /// Adds content to newsletter queue
        /// </summary>
        /// <param name="contentItem"></param>
        /// <returns></returns>
        Task AddToNewsLetter(IContent contentItem);

        /// <summary>
        /// Removes content from a newsletter queue
        /// </summary>
        /// <param name="contentItem"></param>
        /// <returns></returns>
        Task RemoveFromNewsletter(IContent contentItem);
    }
}