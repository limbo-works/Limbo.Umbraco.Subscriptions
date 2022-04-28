using System;
using System.Threading.Tasks;
using Limbo.MailSystem.Mails.Models;

namespace Limbo.Umbraco.Subscriptions.Queues.Jobs.Recuring.Models {
    /// <summary>
    /// Settings for distributing newsletter settings
    /// </summary>
    public class DistributeNewsLettersSettings {
        /// <summary>
        /// How often do we run the background task
        /// </summary>
        public virtual TimeSpan HowOftenWeRepeat { get; set; } = TimeSpan.FromMinutes(1);

        /// <summary>
        /// Delay before task starts on start up
        /// </summary>
        public virtual TimeSpan DelayBeforeWeStart { get; set; } = TimeSpan.FromSeconds(10);

        /// <summary>
        /// How often to send newsletter (Default is null)
        /// </summary>
        /// <remarks>
        /// Cannot be used with <see cref="AllowedStartTime"/> and <see cref="StopTime"/>
        /// </remarks>
        public virtual TimeSpan? HowOftenToSend { get; set; } = null;

        /// <summary>
        /// When it's allowed to send newsletters. Distribution will start on first repeat after this value (Default is null)
        /// </summary>
        /// <remarks>
        /// Cannot be used with <see cref="HowOftenToSend"/>
        /// </remarks>
        public virtual DateTime? AllowedStartTime { get; set; } = null;

        /// <summary>
        /// When to stop sending newsletters (Default is null)
        /// </summary>
        /// <remarks>
        /// Cannot be used with <see cref="HowOftenToSend"/>
        /// </remarks>
        public virtual DateTime? StopTime { get; set; } = null;

        /// <summary>
        /// The page size for creating mails
        /// </summary>
        /// <remarks>
        /// This is used to limit the amount queried from the database and ensure we do not a massive amount of data into memory
        /// </remarks>
        public int PageSize = 100;

        /// <summary>
        /// The name of the newsletter queue to distribute newsletters from
        /// </summary>
        public virtual string QueueName { get; set; } = QueueConstants.DefaultQueueName;

        /// <summary>
        /// Path to email template
        /// </summary>
        public virtual string TemplatePath { get; set; } = "~/Views/Mails/Default.cshtml";

        /// <summary>
        /// The subject title of the email
        /// </summary>
        public virtual string SubjectTitle { get; set; } = "Nyt fra hjemmesiden";

        /// <summary>
        /// The method the mail is sent
        /// </summary>
        /// <remarks>
        /// This supports any method that you can write in code. This will be called for every mail. Default is Console.WriteLine
        /// </remarks>
        public virtual Func<Mail, Task> SendMailMethod { get; set; } = mail => {
            Console.WriteLine(mail.Body);
            return Task.CompletedTask;
        };
    }
}