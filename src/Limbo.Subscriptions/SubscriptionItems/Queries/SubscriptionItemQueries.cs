using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Subscriptions.Persistence.Contexts;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.SubscriptionItems.Services;
using Limbo.Subscriptions.Bases.GraphQL.Queries;

namespace Limbo.Subscriptions.SubscriptionItems.Queries {
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
