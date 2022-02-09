using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.DbMappings {
    internal class SubscriptionItemEntityConfiguration : IEntityTypeConfiguration<SubscriptionItem> {
        public void Configure(EntityTypeBuilder<SubscriptionItem> builder) {
        }
    }
}
