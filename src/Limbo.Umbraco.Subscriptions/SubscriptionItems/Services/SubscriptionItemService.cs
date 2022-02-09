using System.Data;
using System.Net;
using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;
using Limbo.Umbraco.Subscriptions.Bases.Services.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscriptions.SubscriptionItems.Services {
    public class SubscriptionItemService : CrudServiceBase<SubscriptionItem, ISubscriptionItemRepository>, ISubscriptionItemService {
        public SubscriptionItemService(ISubscriptionItemRepository repository, ILogger<ServiceBase<ISubscriptionItemRepository>> logger) : base(repository, logger) {
        }

        public async Task<IServiceResponse<SubscriptionItem>> AddCategories(int id, int[] categoryIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddCategories(id, categoryIds);
            }, HttpStatusCode.Created, IsolationLevel.Snapshot);
        }

        public async Task<IServiceResponse<SubscriptionItem>> AddNewsletterQueues(int id, int[] newsletterQueueIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddNewsletterQueues(id, newsletterQueueIds);
            }, HttpStatusCode.Created, IsolationLevel.Snapshot);
        }

        public async Task<IServiceResponse<SubscriptionItem>> AddSubscribers(int id, int[] subscriberIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddSubscribers(id, subscriberIds);
            }, HttpStatusCode.Created, IsolationLevel.Snapshot);
        }

        public async Task<IServiceResponse<SubscriptionItem>> RemoveCategories(int id, int[] categoryIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.RemoveCategories(id, categoryIds);
            }, HttpStatusCode.Created, IsolationLevel.Snapshot);
        }

        public async Task<IServiceResponse<SubscriptionItem>> RemoveNewsletterQueues(int id, int[] newsletterQueueIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.RemoveNewsletterQueues(id, newsletterQueueIds);
            }, HttpStatusCode.Created, IsolationLevel.Snapshot);
        }

        public async Task<IServiceResponse<SubscriptionItem>> RemoveSubscribers(int id, int[] subscriberIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.RemoveSubscribers(id, subscriberIds);
            }, HttpStatusCode.Created, IsolationLevel.Snapshot);
        }
    }
}
