using System.Data;
using System.Net;
using System.Threading.Tasks;
using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Services.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.Subscribers.Services {
    public class SubscriberService : CrudServiceBase<Subscriber, ISubscriberRepository>, ISubscriberService {
        public SubscriberService(ISubscriberRepository repository, ILogger<ServiceBase<ISubscriberRepository>> logger) : base(repository, logger) {
        }

        public async Task<IServiceResponse<Subscriber>> AddCategories(int id, int[] categoryIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddCategories(id, categoryIds);
            }, HttpStatusCode.Created, IsolationLevel.Snapshot);
        }

        public async Task<IServiceResponse<Subscriber>> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.Created, IsolationLevel.Snapshot);
        }

        public async Task<IServiceResponse<Subscriber>> RemoveCategories(int id, int[] categoryIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.RemoveCategories(id, categoryIds);
            }, HttpStatusCode.OK, IsolationLevel.Snapshot);
        }

        public async Task<IServiceResponse<Subscriber>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.RemoveSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.OK, IsolationLevel.Snapshot);
        }
    }
}
