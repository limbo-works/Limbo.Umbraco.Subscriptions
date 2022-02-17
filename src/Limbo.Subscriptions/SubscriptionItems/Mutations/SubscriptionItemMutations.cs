using System.Threading.Tasks;
using AutoMapper;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.Bases.GraphQL.Mutations;
using Limbo.Subscriptions.Bases.GraphQL.Responses;
using Limbo.Subscriptions.SubscriptionItems.Models;
using Limbo.Subscriptions.SubscriptionItems.Services;

namespace Limbo.Subscriptions.SubscriptionItems.Mutations {
    [ExtendObjectType(typeof(Mutation))]
    public class SubscriptionItemMutations {
        public async Task<SubscriptionItem> CreateSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, SubscriptionItem subscriptionItem) {
            var response = await subscriptionItemService.Add(subscriptionItem);
            return Response.CreateResponse(response);
        }

        public async Task<SubscriptionItem> DeleteSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id) {
            var response = await subscriptionItemService.DeleteById(id);
            return Response.CreateResponse(response);
        }

        public async Task<SubscriptionItem> UpdateSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, [Service] IMapper mapper, SubscriptionItemUpdateInput subscriptionItem) {
            var response = await subscriptionItemService.Update(mapper.Map<SubscriptionItem>(subscriptionItem));
            return Response.CreateResponse(response);
        }

        public async Task<SubscriptionItem> AddCategoriesToSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id, int[] categoryIds) {
            var response = await subscriptionItemService.AddCategories(id, categoryIds);
            return Response.CreateResponse(response);
        }

        public async Task<SubscriptionItem> RemoveCategoriesFromSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id, int[] categoryIds) {
            var response = await subscriptionItemService.RemoveCategories(id, categoryIds);
            return Response.CreateResponse(response);
        }

        public async Task<SubscriptionItem> AddSubscribersToSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id, int[] subscriberIds) {
            var response = await subscriptionItemService.AddSubscribers(id, subscriberIds);
            return Response.CreateResponse(response);
        }

        public async Task<SubscriptionItem> RemoveSubscribersFromSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id, int[] subscriberIds) {
            var response = await subscriptionItemService.RemoveSubscribers(id, subscriberIds);
            return Response.CreateResponse(response);
        }

        public async Task<SubscriptionItem> AddNewsletterQueuesToSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id, int[] newsletterQueueIds) {
            var response = await subscriptionItemService.AddNewsletterQueues(id, newsletterQueueIds);
            return Response.CreateResponse(response);
        }

        public async Task<SubscriptionItem> RemoveNewsletterQueuesFromSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id, int[] newsletterQueueIds) {
            var response = await subscriptionItemService.RemoveNewsletterQueues(id, newsletterQueueIds);
            return Response.CreateResponse(response);
        }
    }
}
