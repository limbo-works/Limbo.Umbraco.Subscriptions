using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;

namespace Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Repositories {
    public interface INewsletterQueueRepository : IDbCrudRepository<NewsletterQueue> {
        Task<NewsletterQueue> AddSubscriptionItems(int id, int[] subscriptionItemIds);
        Task<NewsletterQueue> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}
