using System.Collections.Generic;
using System.Threading.Tasks;
using Limbo.MailSystem.Mails.Models;
using Limbo.MailSystem.Receivers.Models;
using Limbo.MailSystem.Senders.Models;
using Limbo.MailSystem.Settings.Models;
using Razor.Templating.Core;

namespace Limbo.MailSystem.Templates.RazorTemplates.Builders {

    /// <inheritdoc/>
    public class RazorBuilder : IRazorBuilder {
        private readonly MailSettings _mailSettings;

        /// <inheritdoc/>
        public RazorBuilder(MailSettings mailSettings) {
            _mailSettings = mailSettings;
        }

        /// <inheritdoc/>
        public virtual async Task<Mail> BuildMail(ICollection<Recipient> receivers, string subject, string viewPath, ITemplateModel templateModel) {
            return await BuildMail(new Sender(_mailSettings.DefaultSenderName, _mailSettings.DefaultSenderEmail), receivers, subject, viewPath, templateModel);
        }

        /// <inheritdoc/>
        public virtual async Task<Mail> BuildMail(Sender from, ICollection<Recipient> receivers, string subject, string viewPath, ITemplateModel templateModel) {
            return new Mail(from, receivers, subject, await BuildMailBody(viewPath, templateModel));
        }

        /// <inheritdoc/>
        public virtual async Task<string> BuildMailBody(string viewPath, ITemplateModel templateModel) {
            return await RazorTemplateEngine.RenderAsync(viewPath, templateModel);
        }
    }
}
