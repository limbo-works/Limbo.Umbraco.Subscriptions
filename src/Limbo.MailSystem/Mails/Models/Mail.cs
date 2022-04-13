using System.Collections.Generic;
using Limbo.MailSystem.Receivers.Models;
using Limbo.MailSystem.Senders.Models;

namespace Limbo.MailSystem.Mails.Models {
    /// <summary>
    /// Represents a mail
    /// </summary>
    public class Mail {
        /// <summary>
        /// Creates a mail
        /// </summary>
        /// <param name="from"></param>
        /// <param name="receivers"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        public Mail(Sender from, ICollection<Recipient> receivers, string subject, string body) {
            From = from;
            Recipients = receivers;
            Subject = subject;
            Body = body;
        }

        /// <summary>
        /// The sender of the mail
        /// </summary>
        public virtual Sender From { get; set; }

        /// <summary>
        /// The recipients of the mail
        /// </summary>
        public virtual ICollection<Recipient> Recipients { get; set; }

        /// <summary>
        /// The subject of the mail
        /// </summary>
        public virtual string Subject { get; set; }

        /// <summary>
        /// The body of the mail
        /// </summary>
        public virtual string Body { get; set; }
    }
}
