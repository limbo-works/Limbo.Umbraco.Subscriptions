using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Limbo.MailSystem.Mails.Models;

namespace Limbo.MailSystem.Distribution.Services {
    public interface IEmailDistributorService {
        void QueueDistributeEmails(List<Mail> mails, Func<Mail, Task> sendEmail);
    }
}