using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.MailSystem.Persisence.MailSegments.Models;

namespace Limbo.MailSystem.Persisence.SegmentTypes.Models {
    /// <summary>
    /// A segment type
    /// </summary>
    public class SegmentType : GenericId {

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
