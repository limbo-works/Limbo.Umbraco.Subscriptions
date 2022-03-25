using System.Collections.Generic;
using System.Threading.Tasks;
using Limbo.MailSystem.Mails.Models;
using Limbo.MailSystem.Receivers.Models;
using Limbo.MailSystem.Senders.Models;

namespace Limbo.MailSystem.Templates.RazorTemplates.Builders {
    public interface IRazorBuilder {
        Task<Mail> BuildMail(ICollection<Recipient> receivers, string subject, string viewPath, ITemplateModel subscriberInformation);
        Task<Mail> BuildMail(Sender from, ICollection<Recipient> receivers, string subject, string viewPath, ITemplateModel subscriberInformation);
        Task<string> BuildMailBody(string viewPath, ITemplateModel subscriberInformation);
    }
}