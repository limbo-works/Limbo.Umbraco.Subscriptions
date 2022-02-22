using System.Collections.Generic;
using Limbo.MailSystem.Mails.Models;
using Limbo.MailSystem.Receivers.Models;
using Limbo.MailSystem.Senders.Models;
using Limbo.MailSystem.TemplateBuilders.SimpleText.Models;

namespace Limbo.MailSystem.TemplateBuilders.SimpleText.Builders {
    public interface ISimpleTextBuilder {
        Mail BuildMail(ICollection<Receiver> receivers, string subject, string body, IEnumerable<TextReplacement> textReplacements);
        Mail BuildMail(Sender from, ICollection<Receiver> receivers, string subject, string body, IEnumerable<TextReplacement> textReplacements);
        string BuildMailBody(string body, IEnumerable<TextReplacement> textReplacements);
    }
}