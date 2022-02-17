using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.DbMappings {
    internal class SubscriptionSystemEntityConfiguration : IEntityTypeConfiguration<SubscriptionSystem> {
        public void Configure(EntityTypeBuilder<SubscriptionSystem> builder) {
        }
    }
}
