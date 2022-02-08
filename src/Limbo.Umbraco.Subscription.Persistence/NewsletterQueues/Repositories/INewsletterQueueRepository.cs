using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;

namespace Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Repositories {
    public interface INewsletterQueueRepository : IDbCrudRepository<NewsletterQueue> {
    }
}
