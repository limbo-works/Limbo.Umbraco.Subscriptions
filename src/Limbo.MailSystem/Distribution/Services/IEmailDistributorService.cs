using System;
using System.Collections.Generic;
using Limbo.MailSystem.Mails.Models;

namespace Limbo.MailSystem.Distribution.Services {
    public interface IEmailDistributorService {
        void QueueDistributeEmails(List<Mail> mails, Action<Mail> sendEmail)
    }
}