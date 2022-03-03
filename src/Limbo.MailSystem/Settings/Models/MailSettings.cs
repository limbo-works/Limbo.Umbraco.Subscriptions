namespace Limbo.MailSystem.Settings.Models {
    /// <summary>
    /// Represents the mail setting available
    /// </summary>
    public class MailSettings {
        /// <summary>
        /// The default sender email to use
        /// </summary>
        public string DefaultSenderEmail { get; set; } = "";
        /// <summary>
        /// The default sender name to use
        /// </summary>
        public string DefaultSenderName { get; set; } = "";
        /// <summary>
        /// Specifies how long of a delay there should be between sending each mail (In milliseconds)
        /// </summary>
        public int DelayBetweenMails { get; set; } = 0;
        /// <summary>
        /// Should the emails be clustered togther
        /// </summary>
        public bool UseClusters { get; set; }
        /// <summary>
        /// Specifies how many mails can be sent in a row
        /// </summary>
        public int ClusterSize { get; set; } = int.MaxValue;
        /// <summary>
        /// Specifies the delay between clusters of mails (In milliseconds)
        /// </summary>
        public int ClusterDelay { get; set; } = 0;
    }
}
