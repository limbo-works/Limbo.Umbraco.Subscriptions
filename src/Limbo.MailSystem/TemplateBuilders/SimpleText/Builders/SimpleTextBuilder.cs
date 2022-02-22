using System.Collections.Generic;
using System.Text.RegularExpressions;
using Limbo.MailSystem.Mails.Models;
using Limbo.MailSystem.Receivers.Models;
using Limbo.MailSystem.Senders.Models;
using Limbo.MailSystem.Settings.Models;
using Limbo.MailSystem.TemplateBuilders.SimpleText.Models;

namespace Limbo.MailSystem.TemplateBuilders.SimpleText.Builders {
    public class SimpleTextBuilder : ISimpleTextBuilder {
        private readonly MailSettings _mailSettings;

        public SimpleTextBuilder(MailSettings mailSettings) {
            _mailSettings = mailSettings;
        }

        public Mail BuildMail(ICollection<Receiver> receivers, string subject, string body, IEnumerable<TextReplacement> textReplacements) {
            return BuildMail(new Sender(_mailSettings.DefaultSenderName, _mailSettings.DefaultSenderEmail), receivers, subject, body, textReplacements);
        }

        public Mail BuildMail(Sender from, ICollection<Receiver> receivers, string subject, string body, IEnumerable<TextReplacement> textReplacements) {
            return new Mail(from, receivers, subject, BuildMailBody(body, textReplacements));
        }

        public string BuildMailBody(string body, IEnumerable<TextReplacement> textReplacements) {
            foreach (var replacement in textReplacements) {
                body = Regex.Replace(body, replacement.Pattern, replacement.Value);
            }
            return body;
        }
    }
}
