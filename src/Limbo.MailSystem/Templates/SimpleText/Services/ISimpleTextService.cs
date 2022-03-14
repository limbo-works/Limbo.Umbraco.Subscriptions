using System.Threading.Tasks;
using Limbo.DataAccess.Services.Models;
using Limbo.MailSystem.Persisence.MailTemplates.Models;

namespace Limbo.MailSystem.Templates.SimpleText.Services {
    /// <summary>
    /// A service for managing simple text templates
    /// </summary>
    public interface ISimpleTextService {
        /// <summary>
        /// Creates a template
        /// </summary>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        Task<IServiceResponse<MailTemplate>> CreateTemplate(string name, string content);

        /// <summary>
        /// Deletes a template
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IServiceResponse<MailTemplate>> DeleteTemplate(int id);

        /// <summary>
        /// Gets a template
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<MailTemplate?> GetTemplate(int id);

        /// <summary>
        /// Updates a templates content
        /// </summary>
        /// <param name="id"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        Task<IServiceResponse<MailTemplate>?> UpdateTemplateContent(int id, string content);
    }
}