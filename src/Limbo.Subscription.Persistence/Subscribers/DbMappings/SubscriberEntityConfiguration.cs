using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.Subscriptions.Persistence.Subscribers.DbMappings {
    internal class SubscriberEntityConfiguration : IEntityTypeConfiguration<Subscriber> {
        public void Configure(EntityTypeBuilder<Subscriber> builder) {
        }
    }
}
