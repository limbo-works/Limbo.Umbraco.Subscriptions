using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.DbMappings {
    internal class NewsletterQueueEntityConfiguration : IEntityTypeConfiguration<NewsletterQueue> {
        public void Configure(EntityTypeBuilder<NewsletterQueue> builder) {
            builder.Property(p => p.ConcurrencyStamp).IsRowVersion();
        }
    }
}
