using System.Collections.Generic;
using Limbo.EntityFramework.Models;
using Limbo.MailSystem.Persisence.MailSegments.Models;

namespace Limbo.MailSystem.Persisence.MailTemplates.Models {
    /// <summary>
    /// A template for a mail
    /// </summary>
    public class MailTemplate : IGenericId {

        /// <inheritdoc/>
        public virtual int Id { get; set; }

        /// <summary>
        /// The name of the template
        /// </summary>
        public virtual string? Name { get; set; }

        /// <summary>
        /// The segments of the mail
        /// </summary>

        public virtual List<MailSegment> MailSegments { get; set; } = new();
    }
}
