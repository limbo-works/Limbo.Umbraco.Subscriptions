using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.DbMappings {
    internal class NewsletterQueueEntityConfiguration : IEntityTypeConfiguration<NewsletterQueue> {
        public void Configure(EntityTypeBuilder<NewsletterQueue> builder) {
        }
    }
}
