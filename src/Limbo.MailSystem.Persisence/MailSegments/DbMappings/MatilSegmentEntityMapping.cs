using Limbo.MailSystem.Persisence.MailSegments.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.MailSystem.Persisence.MailSegments.DbMappings {
    internal class MatilSegmentEntityMapping : IEntityTypeConfiguration<MailSegment> {
        public void Configure(EntityTypeBuilder<MailSegment> builder) {
            builder.Property(p => p.NVarCharValue).HasMaxLength(512);
        }
    }
}
