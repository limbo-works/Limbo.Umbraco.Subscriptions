using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.SubscriptionItems.Services;
using Limbo.Subscriptions.Bases.GraphQL.Queries;
using System.Data;
using HotChocolate.AspNetCore.Authorization;

namespace Limbo.Subscriptions.SubscriptionItems.Queries {
    [ExtendObjectType(typeof(Query))]
    public class SubscriptionItemQueries {
        [Authorize]
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<SubscriptionItem>> GetSubscriptionItems([Service] ISubscriptionItemService subscriptionItemService) {
            var response = (await subscriptionItemService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            if (response is not null) {
                return response;
            } else {
                return Enumerable.Empty<SubscriptionItem>().AsQueryable();
            }
        }

        [Authorize]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<SubscriptionItem>> GetSubscriptionItemById([Service] ISubscriptionItemService subscriptionItemService) {
            var response = (await subscriptionItemService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            return response;
        }
    }
}
