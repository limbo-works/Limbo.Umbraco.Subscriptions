using System;
using System.Threading.Tasks;
using Limbo.MailSystem.Mails.Models;

namespace Limbo.Umbraco.Subscriptions.Queues.Jobs.Recuring.Models {
    public class DistributeNewsLettersSettings {
        public TimeSpan HowOftenWeRepeat { get; set; } = TimeSpan.FromMinutes(1);
        public TimeSpan DelayBeforeWeStart { get; set; } = TimeSpan.FromSeconds(10);

        public int PageSize = 100;
        public string QueueName { get; set; } = QueueConstants.DefaultQueueName;
        public string TemplatePath { get; set; } = "~/Views/Mails/Default.cshtml";
        public string SubjectTitle { get; set; } = "Nyt fra hjemmesiden";
        public Func<Mail, Task> SendMailMethod { get; set; } = mail => {
            Console.WriteLine(mail.Body);
            return Task.CompletedTask;
        };
    }
}