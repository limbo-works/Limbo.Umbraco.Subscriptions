using System.Collections.Generic;
using Limbo.MailSystem.Mails.Models;
using Limbo.MailSystem.Receivers.Models;
using Limbo.MailSystem.Senders.Models;
using Limbo.MailSystem.Templates.SimpleText.Models;

namespace Limbo.MailSystem.Templates.SimpleText.Builders {
    /// <summary>
    /// A simple text builder that uses simple regex replacement to create a mail
    /// </summary>
    public interface ISimpleTextBuilder {
        /// <summary>
        /// Builds a mail
        /// </summary>
        /// <param name="receivers"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="textReplacements"></param>
        /// <returns></returns>
        Mail BuildMail(ICollection<Recipient> receivers, string subject, string body, IEnumerable<TextReplacement> textReplacements);

        /// <summary>
        /// Builds a mail
        /// </summary>
        /// <param name="from"></param>
        /// <param name="receivers"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="textReplacements"></param>
        /// <returns></returns>
        Mail BuildMail(Sender from, ICollection<Recipient> receivers, string subject, string body, IEnumerable<TextReplacement> textReplacements);

        /// <summary>
        /// Builds a mails body
        /// </summary>
        /// <param name="body"></param>
        /// <param name="textReplacements"></param>
        /// <returns></returns>
        string BuildMailBody(string body, IEnumerable<TextReplacement> textReplacements);
    }
}