using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace Limbo.Umbraco.Subscriptions.Content.Events.Managers {
    internal interface IContentNewsletterManager {
        Task AddToNewsLetter(IContent contentItem);
        Task RemoveFromNewsletter(IContent contentItem);
    }
}