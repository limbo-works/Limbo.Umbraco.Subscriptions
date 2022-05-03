using Limbo.EntityFramework.Conventions;
using Limbo.MailSystem.Persisence.SegmentTypes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.MailSystem.Persisence.SegmentTypes.DbMappings {
    internal class SegmentTypeEntityConfiguration : IEntityTypeConfiguration<SegmentType> {
        public void Configure(EntityTypeBuilder<SegmentType> builder) {
            builder.Property(p => p.Alias).HasMaxLength(DefaultValues.DefaultStringLength);
        }
    }
}
