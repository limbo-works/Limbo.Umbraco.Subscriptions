using Limbo.EntityFramework.Conventions;
using Limbo.MailSystem.Persistence.MailTemplates.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.MailSystem.Persistence.MailTemplates.DbMappings {
    internal class MailTemplateEntityMapping : IEntityTypeConfiguration<MailTemplate> {
        public void Configure(EntityTypeBuilder<MailTemplate> builder) {
            builder.Property(p => p.Name).HasMaxLength(DefaultValues.DefaultStringLength);
        }
    }
}
