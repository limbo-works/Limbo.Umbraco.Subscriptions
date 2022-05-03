using Limbo.MailSystem.Persistence.MailSegments.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.MailSystem.Persistence.MailSegments.DbMappings {
    internal class MailSegmentEntityMapping : IEntityTypeConfiguration<MailSegment> {
        public void Configure(EntityTypeBuilder<MailSegment> builder) {
            builder.Property(p => p.NVarCharValue).HasMaxLength(512);
        }
    }
}
