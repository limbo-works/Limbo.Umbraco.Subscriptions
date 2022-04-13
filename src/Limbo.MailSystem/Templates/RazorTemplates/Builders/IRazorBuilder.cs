using System.Collections.Generic;
using System.Threading.Tasks;
using Limbo.MailSystem.Mails.Models;
using Limbo.MailSystem.Receivers.Models;
using Limbo.MailSystem.Senders.Models;

namespace Limbo.MailSystem.Templates.RazorTemplates.Builders {
    /// <summary>
    /// A builder that builds mails from razor templates
    /// </summary>
    public interface IRazorBuilder {
        /// <summary>
        /// Builds a mail
        /// </summary>
        /// <param name="receivers"></param>
        /// <param name="subject"></param>
        /// <param name="viewPath"></param>
        /// <param name="subscriberInformation"></param>
        /// <returns></returns>
        Task<Mail> BuildMail(ICollection<Recipient> receivers, string subject, string viewPath, ITemplateModel subscriberInformation);

        /// <summary>
        /// Builds a mail
        /// </summary>
        /// <param name="from"></param>
        /// <param name="receivers"></param>
        /// <param name="subject"></param>
        /// <param name="viewPath"></param>
        /// <param name="subscriberInformation"></param>
        /// <returns></returns>
        Task<Mail> BuildMail(Sender from, ICollection<Recipient> receivers, string subject, string viewPath, ITemplateModel subscriberInformation);

        /// <summary>
        /// Builds a mail body
        /// </summary>
        /// <param name="viewPath"></param>
        /// <param name="subscriberInformation"></param>
        /// <returns></returns>
        Task<string> BuildMailBody(string viewPath, ITemplateModel subscriberInformation);
    }
}