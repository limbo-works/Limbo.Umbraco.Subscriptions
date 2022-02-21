using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.DataAccess.Conventions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.DbMappings {
    /// <summary>
    /// Configuration for api claims
    /// </summary>
    public class ApiClaimEntityConfiguration : IEntityTypeConfiguration<ApiClaim> {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<ApiClaim> builder) {
            builder.Property(p => p.Type)
                .HasMaxLength(DefaultValues.DefaultStringLength)
                .IsRequired();

            builder.Property(p => p.Value)
                .HasMaxLength(DefaultValues.DefaultValueLength);
        }
    }
}
