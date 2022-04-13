namespace Limbo.MailSystem.Senders.Models {
    /// <summary>
    /// Represents a email sender
    /// </summary>
    public class Sender {
        /// <summary>
        /// Creates a sender
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        public Sender(string name, string email) {
            Name = name;
            Email = email;
        }

        /// <summary>
        /// The name of the sender
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// The email of the sender
        /// </summary>
        public virtual string Email { get; set; }
    }
}
