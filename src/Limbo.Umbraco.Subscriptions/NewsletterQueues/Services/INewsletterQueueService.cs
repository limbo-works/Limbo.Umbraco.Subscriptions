using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;
using Limbo.Umbraco.Subscriptions.Bases.Services.Models;

namespace Limbo.Umbraco.Subscriptions.NewsletterQueues.Services {
    public interface INewsletterQueueService : ICrudServiceBase<NewsletterQueue, INewsletterQueueRepository> {
        Task<IServiceResponse<NewsletterQueue>> AddSubscriptionItems(int id, int[] subscriptionItemIds);
        Task<IServiceResponse<NewsletterQueue>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}