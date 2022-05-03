using System.Collections.Generic;
using Limbo.EntityFramework.Models;
using Limbo.MailSystem.Persistence.MailSegments.Models;

namespace Limbo.MailSystem.Persistence.SegmentTypes.Models {
    /// <summary>
    /// A segment type
    /// </summary>
    public class SegmentType : IGenericId {

        /// <inheritdoc/>
        public virtual int Id { get; set; }

        /// <summary>
        /// The alias of the segment
        /// </summary>
        public virtual string? Alias { get; set; }

        /// <summary>
        /// The mail segments with the type
        /// </summary>

        public virtual List<MailSegment> MailSegments { get; set; } = new();
    }
}
