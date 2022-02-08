using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;

namespace Limbo.Umbraco.Subscriptions.NewsletterQueues.Services {
    public interface INewsletterQueueService : ICrudServiceBase<NewsletterQueue, INewsletterQueueRepository> {
    }
}