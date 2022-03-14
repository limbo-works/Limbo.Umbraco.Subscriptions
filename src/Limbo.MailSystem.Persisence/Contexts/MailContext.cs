using System.Reflection;
using Limbo.MailSystem.Persisence.MailSegments.Models;
using Limbo.MailSystem.Persisence.MailTemplates.Models;
using Limbo.MailSystem.Persisence.SegmentTypes.Models;
using Microsoft.EntityFrameworkCore;

namespace Limbo.MailSystem.Persisence.Contexts {
    /// <summary>
    /// The mail context
    /// </summary>
    public class MailContext : DbContext, IMailContext {
        /// <inheritdoc/>
        public MailContext(DbContextOptions options) : base(options) {
        }

        /// <inheritdoc/>
        public DbContext Context => this;

        /// <inheritdoc/>
        public DbSet<MailTemplate>? MailTemplates { get; set; }

        /// <inheritdoc/>
        public DbSet<MailSegment>? MailSegments { get; set; }

        /// <inheritdoc/>
        public DbSet<SegmentType>? SegmentTypes { get; set; }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
