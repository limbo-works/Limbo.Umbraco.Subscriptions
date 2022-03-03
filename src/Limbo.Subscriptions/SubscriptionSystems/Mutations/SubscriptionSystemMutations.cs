using System.Threading.Tasks;
using AutoMapper;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Limbo.Subscriptions.Bases.GraphQL.Mutations;
using Limbo.Subscriptions.Bases.GraphQL.Responses;
using Limbo.Subscriptions.SubscriptionSystems.Models;
using Limbo.Subscriptions.SubscriptionSystems.Services;
using HotChocolate.AspNetCore.Authorization;

namespace Limbo.Subscriptions.SubscriptionSystems.Mutations {
    [ExtendObjectType(typeof(Mutation))]
    public class SubscriptionSystemMutations {
        [Authorize]
        public async Task<SubscriptionSystem?> CreateSubscriptionSystem([Service] ISubscriptionSystemService subscriptionSystemService, SubscriptionSystem subscriptionSystem) {
            var response = await subscriptionSystemService.Add(subscriptionSystem);
            return Response.CreateResponse(response);
        }

        [Authorize]
        public async Task<SubscriptionSystem?> DeleteSubscriptionSystem([Service] ISubscriptionSystemService subscriptionSystemService, int id) {
            var response = await subscriptionSystemService.DeleteById(id);
            return Response.CreateResponse(response);
        }

        [Authorize]
        public async Task<SubscriptionSystem?> UpdateSubscriptionSystem([Service] ISubscriptionSystemService subscriptionSystemService, [Service] IMapper mapper, SubscriptionSystemUpdateInput subscriptionSystem) {
            var response = await subscriptionSystemService.Update(mapper.Map<SubscriptionSystem>(subscriptionSystem));
            return Response.CreateResponse(response);
        }
    }
}
