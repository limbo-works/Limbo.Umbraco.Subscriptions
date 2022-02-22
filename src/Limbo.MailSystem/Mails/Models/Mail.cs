using System.Collections.Generic;
using Limbo.MailSystem.Receivers.Models;
using Limbo.MailSystem.Senders.Models;

namespace Limbo.MailSystem.Mails.Models {
    public class Mail {
        public Mail(Sender from, ICollection<Receiver> receivers, string subject, string body) {
            From = from;
            Receivers = receivers;
            Subject = subject;
            Body = body;
        }

        public Sender From { get; set; }
        public ICollection<Receiver> Receivers { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
