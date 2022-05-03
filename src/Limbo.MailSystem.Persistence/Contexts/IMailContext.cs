using Limbo.EntityFramework.Contexts.Models;
using Limbo.MailSystem.Persistence.MailSegments.Models;
using Limbo.MailSystem.Persistence.MailTemplates.Models;
using Limbo.MailSystem.Persistence.SegmentTypes.Models;
using Microsoft.EntityFrameworkCore;

namespace Limbo.MailSystem.Persistence.Contexts {
    /// <summary>
    /// A context for mail data
    /// </summary>
    public interface IMailContext : IDbContext {
        /// <summary>
        /// Mail templates
        /// </summary>
        DbSet<MailTemplate>? MailTemplates { get; set; }

        /// <summary>
        /// Mail segments
        /// </summary>
        DbSet<MailSegment>? MailSegments { get; set; }

        /// <summary>
        /// Segment types
        /// </summary>
        DbSet<SegmentType>? SegmentTypes { get; set; }
    }
}