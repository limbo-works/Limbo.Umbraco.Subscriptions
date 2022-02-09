using System.Threading.Tasks;
using AutoMapper;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL.Mutations;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL.Responses;
using Limbo.Umbraco.Subscriptions.SubscriptionSystems.Models;
using Limbo.Umbraco.Subscriptions.SubscriptionSystems.Services;

namespace Limbo.Umbraco.Subscriptions.SubscriptionSystems.Mutations {
    [ExtendObjectType(typeof(Mutation))]
    public class SubscriptionSystemMutations {
        public async Task<SubscriptionSystem> CreateSubscriptionSystem([Service] ISubscriptionSystemService subscriptionSystemService, SubscriptionSystem subscriptionSystem) {
            var response = await subscriptionSystemService.Add(subscriptionSystem);
            return Response.CreateResponse(response);
        }

        public async Task<SubscriptionSystem> DeleteSubscriptionSystem([Service] ISubscriptionSystemService subscriptionSystemService, int id) {
            var response = await subscriptionSystemService.DeleteById(id);
            return Response.CreateResponse(response);
        }

        public async Task<SubscriptionSystem> UpdateSubscriptionSystem([Service] ISubscriptionSystemService subscriptionSystemService, [Service] IMapper mapper, SubscriptionSystemUpdateInput subscriptionSystem) {
            var response = await subscriptionSystemService.Update(mapper.Map<SubscriptionSystem>(subscriptionSystem));
            return Response.CreateResponse(response);
        }
    }
}
