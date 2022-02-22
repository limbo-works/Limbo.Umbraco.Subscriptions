namespace Limbo.MailSystem.Senders.Models {
    public class Sender {
        public Sender(string name, string email) {
            Name = name;
            Email = email;
        }

        public string Name { get; set; }
        public string Email { get; set; }
    }
}
