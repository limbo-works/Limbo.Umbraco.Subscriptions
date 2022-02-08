using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.Umbraco.Subscription.Persistence.Subscribers.DbMappings {
    internal class SubscriberEntityConfiguration : IEntityTypeConfiguration<Subscriber> {
        public void Configure(EntityTypeBuilder<Subscriber> builder) {
            builder.Property(p => p.ConcurrencyStamp).IsRowVersion();
        }
    }
}
