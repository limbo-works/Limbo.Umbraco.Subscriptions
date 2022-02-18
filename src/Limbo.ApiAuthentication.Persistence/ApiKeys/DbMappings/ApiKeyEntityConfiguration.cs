using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.DataAccess.Conventions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.DbMappings {
    internal class ApiKeyEntityConfiguration : IEntityTypeConfiguration<ApiKey> {
        public void Configure(EntityTypeBuilder<ApiKey> builder) {
            builder.Property(p => p.Key).HasMaxLength(DefaultValues.DefaultApiKeyLength);
        }
    }
}
