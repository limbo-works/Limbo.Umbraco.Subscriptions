using System.Threading.Tasks;
using AutoMapper;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Bases.GraphQL.Mutations;
using Limbo.Subscriptions.Bases.GraphQL.Responses;
using Limbo.Subscriptions.Subscribers.Models;
using Limbo.Subscriptions.Subscribers.Services;
using HotChocolate.AspNetCore.Authorization;

namespace Limbo.Subscriptions.Subscribers.Mutations {
    [ExtendObjectType(typeof(Mutation))]
    public class SubscriberMutations {
        [Authorize]
        public async Task<Subscriber?> CreateSubscriber([Service] ISubscriberService subscriberService, Subscriber subscriber) {
            var response = await subscriberService.Add(subscriber);
            return Response.CreateResponse(response);
        }

        [Authorize]
        public async Task<Subscriber?> DeleteSubscriberById([Service] ISubscriberService subscriberService, int id) {
            var response = await subscriberService.DeleteById(id);
            return Response.CreateResponse(response);
        }

        [Authorize]
        public async Task<Subscriber?> UpdateSubscriber([Service] ISubscriberService subscriberService, [Service] IMapper mapper, SubscriberUpdateInput subscriber) {
            var response = await subscriberService.Update(mapper.Map<Subscriber>(subscriber));
            return Response.CreateResponse(response);
        }

        [Authorize]
        public async Task<Subscriber?> AddCategoriesToSubscriber([Service] ISubscriberService subscriberService, int id, int[] categoryIds) {
            var response = await subscriberService.AddCategories(id, categoryIds);
            return Response.CreateResponse(response);
        }

        [Authorize]
        public async Task<Subscriber?> RemoveCategoriesFromSubscriber([Service] ISubscriberService subscriberService, int id, int[] categoryIds) {
            var response = await subscriberService.RemoveCategories(id, categoryIds);
            return Response.CreateResponse(response);
        }

        [Authorize]
        public async Task<Subscriber?> AddSubscriptionItemsToSubscriber([Service] ISubscriberService subscriberService, int id, int[] subscriptionItemIds) {
            var response = await subscriberService.AddSubscriptionItems(id, subscriptionItemIds);
            return Response.CreateResponse(response);
        }

        [Authorize]
        public async Task<Subscriber?> RemoveSubscriptionItemsFromSubscriber([Service] ISubscriberService subscriberService, int id, int[] subscriptionItemIds) {
            var response = await subscriberService.RemoveSubscriptionItems(id, subscriptionItemIds);
            return Response.CreateResponse(response);
        }
    }
}
