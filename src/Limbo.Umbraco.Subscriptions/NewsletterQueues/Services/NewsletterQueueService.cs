using System.Data;
using System.Net;
using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;
using Limbo.Umbraco.Subscriptions.Bases.Services.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscriptions.NewsletterQueues.Services {
    public class NewsletterQueueService : CrudServiceBase<NewsletterQueue, INewsletterQueueRepository>, INewsletterQueueService {
        public NewsletterQueueService(INewsletterQueueRepository repository, ILogger<ServiceBase<INewsletterQueueRepository>> logger) : base(repository, logger) {
        }

        public async Task<IServiceResponse<NewsletterQueue>> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.Created, IsolationLevel.Snapshot);
        }

        public async Task<IServiceResponse<NewsletterQueue>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.RemoveSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.OK, IsolationLevel.Snapshot);
        }
    }
}
