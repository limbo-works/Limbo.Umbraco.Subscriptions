using System.Threading.Tasks;
using AutoMapper;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL.Mutations;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL.Responses;
using Limbo.Umbraco.Subscriptions.NewsletterQueues.Models;
using Limbo.Umbraco.Subscriptions.NewsletterQueues.Services;

namespace Limbo.Umbraco.Subscriptions.NewsletterQueues.Mutations {
    [ExtendObjectType(typeof(Mutation))]
    public class NewsletterQueueMutations {
        public async Task<NewsletterQueue> CreateNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, NewsletterQueue newsletterQueue) {
            var response = await newsletterQueueService.Add(newsletterQueue);
            return Response.CreateResponse(response);
        }

        public async Task<NewsletterQueue> DeleteNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, int Id) {
            var response = await newsletterQueueService.DeleteById(Id);
            return Response.CreateResponse(response);
        }

        public async Task<NewsletterQueue> UpdateNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, [Service] IMapper mapper, NewsletterQueueUpdateInput newsletterQueue) {
            var response = await newsletterQueueService.Update(mapper.Map<NewsletterQueue>(newsletterQueue));
            return Response.CreateResponse(response);
        }

        public async Task<NewsletterQueue> AddSubscriptionItemsToNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, int id, int[] subscriptionItemIds) {
            var response = await newsletterQueueService.AddSubscriptionItems(id, subscriptionItemIds);
            return Response.CreateResponse(response);
        }

        public async Task<NewsletterQueue> RemoveSubscriptionItemsFromNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, int id, int[] subscriptionItemIds) {
            var response = await newsletterQueueService.RemoveSubscriptionItems(id, subscriptionItemIds);
            return Response.CreateResponse(response);
        }
    }
}
