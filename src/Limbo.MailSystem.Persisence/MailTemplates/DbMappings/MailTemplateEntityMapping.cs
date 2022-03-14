using Limbo.DataAccess.Conventions;
using Limbo.MailSystem.Persisence.MailTemplates.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.MailSystem.Persisence.MailTemplates.DbMappings {
    internal class MailTemplateEntityMapping : IEntityTypeConfiguration<MailTemplate> {
        public void Configure(EntityTypeBuilder<MailTemplate> builder) {
            builder.Property(p => p.Name).HasMaxLength(DefaultValues.DefaultStringLength);
        }
    }
}
