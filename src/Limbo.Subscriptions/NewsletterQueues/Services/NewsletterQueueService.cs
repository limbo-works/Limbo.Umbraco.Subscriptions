﻿using System.Data;
using System.Net;
using System.Threading.Tasks;
using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Services.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.NewsletterQueues.Services {
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