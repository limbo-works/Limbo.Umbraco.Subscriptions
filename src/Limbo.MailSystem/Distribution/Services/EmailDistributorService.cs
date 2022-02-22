using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Limbo.MailSystem.Mails.Models;
using Limbo.MailSystem.Queue.Services;
using Limbo.MailSystem.Settings.Models;

namespace Limbo.MailSystem.Distribution.Services {
    public class EmailDistributorService : IEmailDistributorService {

        private readonly MailSettings _mailSettings;
        private readonly IQueueService _queueService;

        public EmailDistributorService(MailSettings mailSettings, IQueueService queueService) {
            _mailSettings = mailSettings;
            _queueService = queueService;
        }

        public void QueueDistributeEmails(List<Mail> mails, Action<Mail> sendEmail) {
            _queueService.QueueUp(async () => await DistributeEmails(mails, sendEmail));
        }

        private async Task DistributeEmails(List<Mail> mails, Action<Mail> sendEmail) {
            for (int i = 0; i < mails.Count; i++) {

                sendEmail(mails[i]);

                if (_mailSettings.DelayBetweenMails != 0) {
                    await Task.Delay(_mailSettings.DelayBetweenMails);
                }

                if (_mailSettings.UseClusters) {
                    if (i % _mailSettings.ClusterSize == 0) {
                        await Task.Delay(_mailSettings.ClusterDelay);
                    }
                }
            }

            _queueService.RunNextAction();
        }
    }
}
