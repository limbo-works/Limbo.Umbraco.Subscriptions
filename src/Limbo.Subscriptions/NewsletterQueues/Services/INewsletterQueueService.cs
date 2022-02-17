using System.Threading.Tasks;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Repositories;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Services.Models;

namespace Limbo.Subscriptions.NewsletterQueues.Services {
    public interface INewsletterQueueService : ICrudServiceBase<NewsletterQueue, INewsletterQueueRepository> {
        Task<IServiceResponse<NewsletterQueue>> AddSubscriptionItems(int id, int[] subscriptionItemIds);
        Task<IServiceResponse<NewsletterQueue>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}