using System.Collections.Generic;
using System.Text.RegularExpressions;
using Limbo.MailSystem.Mails.Models;
using Limbo.MailSystem.Receivers.Models;
using Limbo.MailSystem.Senders.Models;
using Limbo.MailSystem.Settings.Models;
using Limbo.MailSystem.TemplateBuilders.SimpleText.Models;

namespace Limbo.MailSystem.TemplateBuilders.SimpleText.Builders {
    /// <inheritdoc/>
    public class SimpleTextBuilder : ISimpleTextBuilder {
        private readonly MailSettings _mailSettings;

        /// <inheritdoc/>
        public SimpleTextBuilder(MailSettings mailSettings) {
            _mailSettings = mailSettings;
        }

        /// <inheritdoc/>
        public Mail BuildMail(ICollection<Recipient> receivers, string subject, string body, IEnumerable<TextReplacement> textReplacements) {
            return BuildMail(new Sender(_mailSettings.DefaultSenderName, _mailSettings.DefaultSenderEmail), receivers, subject, body, textReplacements);
        }

        /// <inheritdoc/>
        public Mail BuildMail(Sender from, ICollection<Recipient> receivers, string subject, string body, IEnumerable<TextReplacement> textReplacements) {
            return new Mail(from, receivers, subject, BuildMailBody(body, textReplacements));
        }

        /// <inheritdoc/>
        public string BuildMailBody(string body, IEnumerable<TextReplacement> textReplacements) {
            foreach (var replacement in textReplacements) {
                if (replacement.Pattern == null || replacement.Value == null) {
                    continue;
                }
                body = Regex.Replace(body, replacement.Pattern, replacement.Value);
            }
            return body;
        }
    }
}
