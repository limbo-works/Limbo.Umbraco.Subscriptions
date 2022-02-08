using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscriptions.NewsletterQueues.Services {
    public class NewsletterQueueService : CrudServiceBase<NewsletterQueue, INewsletterQueueRepository>, INewsletterQueueService {
        public NewsletterQueueService(INewsletterQueueRepository repository, ILogger<ServiceBase<INewsletterQueueRepository>> logger) : base(repository, logger) {
        }
    }
}
