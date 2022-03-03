using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Limbo.MailSystem.Mails.Models;
using Limbo.MailSystem.Queue.Services;
using Limbo.MailSystem.Settings.Models;

namespace Limbo.MailSystem.Distribution.Services {
    /// <inheritdoc/>
    public class EmailDistributorService : IEmailDistributorService {

        private readonly MailSettings _mailSettings;
        private readonly IQueueService _queueService;

        /// <inheritdoc/>
        public EmailDistributorService(MailSettings mailSettings, IQueueService queueService) {
            _mailSettings = mailSettings;
            _queueService = queueService;
        }

        /// <inheritdoc/>
        public void QueueDistributeEmails(List<Mail> mails, Func<Mail, Task> sendEmail) {
            _queueService.QueueUp(async () => await DistributeEmails(mails, sendEmail));
        }

        /// <summary>
        /// Distributes emails with the mail settings set
        /// </summary>
        /// <param name="mails"></param>
        /// <param name="sendEmail"></param>
        /// <returns></returns>
        private async Task DistributeEmails(List<Mail> mails, Func<Mail, Task> sendEmail) {
            for (int i = 0; i < mails.Count; i++) {

                await sendEmail.Invoke(mails[i]);

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
