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

        private static readonly string _tablePrefix = "Limbo_Mail";

        /// <inheritdoc/>
        public virtual DbContext Context => this;

        /// <inheritdoc/>
        public virtual DbSet<MailTemplate>? MailTemplates { get; set; }

        /// <inheritdoc/>
        public virtual DbSet<MailSegment>? MailSegments { get; set; }

        /// <inheritdoc/>
        public virtual DbSet<SegmentType>? SegmentTypes { get; set; }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Prefix tables
            foreach (var entityType in modelBuilder.Model.GetEntityTypes()) {
                entityType.SetTableName(_tablePrefix + "_" + entityType.GetTableName());
            }
        }

    }
}
