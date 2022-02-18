using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.DataAccess.Conventions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.DbMappings {
    public class ApiClaimEntityConfiguration : IEntityTypeConfiguration<ApiClaim> {
        public void Configure(EntityTypeBuilder<ApiClaim> builder) {
            builder.Property(p => p.Type)
                .HasMaxLength(DefaultValues.DefaultStringLength)
                .IsRequired();

            builder.Property(p => p.Value)
                .HasMaxLength(DefaultValues.DefaultValueLength);
        }
    }
}
