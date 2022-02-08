using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Repositories {
    public class NewsletterQueueRepository : DbCrudRepositoryBase<NewsletterQueue>, INewsletterQueueRepository {
        public NewsletterQueueRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<NewsletterQueue>> logger) : base(dbContext, logger) {
        }
    }
}
