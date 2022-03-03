namespace Limbo.MailSystem.Receivers.Models {
    /// <summary>
    /// Represents a mail recipient
    /// </summary>
    public class Recipient {
        /// <summary>
        /// The name of the recipient
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The email of the recipient
        /// </summary>
        public string? Email { get; set; }
    }
}
