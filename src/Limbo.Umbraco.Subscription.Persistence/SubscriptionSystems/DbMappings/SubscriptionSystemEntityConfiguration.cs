using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.DbMappings {
    internal class SubscriptionSystemEntityConfiguration : IEntityTypeConfiguration<SubscriptionSystem> {
        public void Configure(EntityTypeBuilder<SubscriptionSystem> builder) {
            builder.Property(p => p.ConcurrencyStamp).IsRowVersion();
        }
    }
}
