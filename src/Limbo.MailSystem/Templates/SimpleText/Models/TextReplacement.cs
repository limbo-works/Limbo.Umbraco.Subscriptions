namespace Limbo.MailSystem.Templates.SimpleText.Models {
    /// <summary>
    /// Represents a text that should be replaced where the Regex pattern matches
    /// </summary>
    public class TextReplacement {
        /// <summary>
        /// The Regex pattern used to match the occurences
        /// </summary>
        public virtual string? Pattern { get; set; }

        /// <summary>
        /// Value to replace the pattern with
        /// </summary>
        public virtual string? Value { get; set; }
    }
}
