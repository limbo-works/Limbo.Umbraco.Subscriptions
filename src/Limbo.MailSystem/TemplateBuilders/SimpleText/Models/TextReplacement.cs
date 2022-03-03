﻿namespace Limbo.MailSystem.TemplateBuilders.SimpleText.Models {
    /// <summary>
    /// Represents a text that should be replaced where the Regex pattern matches
    /// </summary>
    public class TextReplacement {
        /// <summary>
        /// The Regex pattern used to match the occurences
        /// </summary>
        public string? Pattern { get; set; }

        /// <summary>
        /// Value to replace the pattern with
        /// </summary>
        public string? Value { get; set; }
    }
}
