using System.Threading.Tasks;
using AutoMapper;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using Limbo.Subscriptions.Bases.GraphQL.Responses;
using Limbo.Subscriptions.NewsletterQueues.Models;
using Limbo.Subscriptions.NewsletterQueues.Services;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;

namespace Limbo.Subscriptions.NewsletterQueues.Mutations {
    public class NewsletterQueueMutationsBase {

        [Authorize]
        public virtual async Task<NewsletterQueue?> AddSubscriptionItemsToNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, int id, int[] subscriptionItemIds) {
            var response = await newsletterQueueService.AddSubscriptionItems(id, subscriptionItemIds);
            return Response.CreateResponse(response);
        }
        [Authorize]
        public virtual async Task<NewsletterQueue?> CreateNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, NewsletterQueue newsletterQueue) {
            var response = await newsletterQueueService.Add(newsletterQueue);
            return Response.CreateResponse(response);
        }

        [Authorize]
        public virtual async Task<NewsletterQueue?> DeleteNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, int id) {
            var response = await newsletterQueueService.DeleteById(id);
            return Response.CreateResponse(response);
        }

        [Authorize]
        public virtual async Task<NewsletterQueue?> RemoveSubscriptionItemsFromNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, int id, int[] subscriptionItemIds) {
            var response = await newsletterQueueService.RemoveSubscriptionItems(id, subscriptionItemIds);
            return Response.CreateResponse(response);
        }

        [Authorize]
        public virtual async Task<NewsletterQueue?> UpdateNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, [Service] IMapper mapper, NewsletterQueueUpdateInput newsletterQueue) {
            var response = await newsletterQueueService.Update(mapper.Map<NewsletterQueue>(newsletterQueue));
            return Response.CreateResponse(response);
        }
    }
}