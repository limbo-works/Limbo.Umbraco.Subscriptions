using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;
using Limbo.Umbraco.Subscriptions.SubscriptionItems.Services;

namespace Limbo.Umbraco.Subscriptions.SubscriptionItems.Queries {
    [ExtendObjectType(typeof(Query))]
    public class SubscriptionItemQueries {
        [UseDbContext(typeof(SubscriptionDbContext))]
        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<SubscriptionItem>> GetSubscriptionItems([Service] ISubscriptionItemService subscriptionItemService) {
            var response = (await subscriptionItemService.GetAll()).ReponseValue;
            if (response is not null) {
                return response.ToList();
            } else {
                return Enumerable.Empty<SubscriptionItem>();
            }
        }

        [UseDbContext(typeof(SubscriptionDbContext))]
        [UseFiltering]
        [UseSorting]
        public async Task<SubscriptionItem> GetSubscriptionItemById([Service] ISubscriptionItemService subscriptionItemService, int id) {
            var response = (await subscriptionItemService.GetById(id)).ReponseValue;
            return response;
        }
    }
}
