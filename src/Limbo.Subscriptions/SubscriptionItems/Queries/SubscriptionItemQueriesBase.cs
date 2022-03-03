using System.Data;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Data;
using HotChocolate.Types;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.SubscriptionItems.Services;

namespace Limbo.Subscriptions.SubscriptionItems.Queries {
    public class SubscriptionItemQueriesBase {

        [Authorize]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<SubscriptionItem>?> GetSubscriptionItemById([Service] ISubscriptionItemService subscriptionItemService) {
            var response = (await subscriptionItemService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            return response;
        }
        [Authorize]
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<SubscriptionItem>> GetSubscriptionItems([Service] ISubscriptionItemService subscriptionItemService) {
            var response = (await subscriptionItemService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            if (response is not null) {
                return response;
            } else {
                return Enumerable.Empty<SubscriptionItem>().AsQueryable();
            }
        }
    }
}