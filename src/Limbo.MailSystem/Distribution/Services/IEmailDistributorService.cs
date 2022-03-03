using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Limbo.MailSystem.Mails.Models;

namespace Limbo.MailSystem.Distribution.Services {
    /// <summary>
    /// A service for distribution of mails
    /// </summary>
    public interface IEmailDistributorService {
        /// <summary>
        /// Queues emails for distribution
        /// </summary>
        /// <param name="mails"></param>
        /// <param name="sendEmail"></param>
        void QueueDistributeEmails(List<Mail> mails, Func<Mail, Task> sendEmail);
    }
}