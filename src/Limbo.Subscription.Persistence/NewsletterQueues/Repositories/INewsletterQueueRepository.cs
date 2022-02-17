using System.Threading.Tasks;
using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.Repositories {
    public interface INewsletterQueueRepository : IDbCrudRepository<NewsletterQueue> {
        Task<NewsletterQueue> AddSubscriptionItems(int id, int[] subscriptionItemIds);
        Task<NewsletterQueue> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}
