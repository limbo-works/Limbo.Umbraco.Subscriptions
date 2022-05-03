using Limbo.EntityFramework.Models;
using Limbo.MailSystem.Persisence.MailTemplates.Models;
using Limbo.MailSystem.Persisence.SegmentTypes.Models;

namespace Limbo.MailSystem.Persisence.MailSegments.Models {
    /// <summary>
    /// A segment of a mail
    /// </summary>
    public class MailSegment : IGenericId {

        /// <inheritdoc/>
        public virtual int Id { get; set; }

        /// <summary>
        /// A text value under 512 bytes
        /// </summary>
        public virtual string? NVarCharValue { get; set; }

        /// <summary>
        /// A text value over 512 bytes
        /// </summary>
        public virtual string? NVarCharMaxValue { get; set; }

        /// <summary>
        /// The mail template of the segment
        /// </summary>

        public virtual MailTemplate? MailTemplate { get; set; }

        /// <summary>
        /// The segment type
        /// </summary>
        public virtual SegmentType? SegmentType { get; set; }
    }
}
