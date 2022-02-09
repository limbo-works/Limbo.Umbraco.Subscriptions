using System.Data;
using System.Net;
using System.Threading.Tasks;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscription.Persistence.Categories.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;
using Limbo.Umbraco.Subscriptions.Bases.Services.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscriptions.Categories.Services {
    public class CategoryService : CrudServiceBase<Category, ICategoryRepository>, ICategoryService {
        public CategoryService(ICategoryRepository repository, ILogger<ServiceBase<ICategoryRepository>> logger) : base(repository, logger) {
        }

        public async Task<IServiceResponse<Category>> AddSubscribers(int id, int[] subscriberIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddSubscribers(id, subscriberIds);
            }, HttpStatusCode.Created, IsolationLevel.Snapshot);
        }

        public async Task<IServiceResponse<Category>> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.Created, IsolationLevel.Snapshot);
        }

        public async Task<IServiceResponse<Category>> RemoveSubscribers(int id, int[] subscriberIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.RemoveSubscribers(id, subscriberIds);
            }, HttpStatusCode.OK, IsolationLevel.Snapshot);
        }

        public async Task<IServiceResponse<Category>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.RemoveSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.OK, IsolationLevel.Snapshot);
        }
    }
}
