using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models;
using Limbo.Umbraco.Subscriptions.SubscriptionSystems.Services;

namespace Limbo.Umbraco.Subscriptions.SubscriptionSystems.Queries {
    [ExtendObjectType(typeof(Query))]
    public class SubscriptionSystemQueries {
        [UseDbContext(typeof(SubscriptionDbContext))]
        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<SubscriptionSystem>> GetSubscriptionSystems([Service] ISubscriptionSystemService subscriptionSystemService) {
            var response = (await subscriptionSystemService.GetAll()).ReponseValue;
            if (response is not null) {
                return response.ToList();
            } else {
                return Enumerable.Empty<SubscriptionSystem>();
            }
        }

        [UseDbContext(typeof(SubscriptionDbContext))]
        [UseFiltering]
        [UseSorting]
        public async Task<SubscriptionSystem> GetSubscriptionSystemById([Service] ISubscriptionSystemService subscriptionSystemService, int id) {
            var response = (await subscriptionSystemService.GetById(id)).ReponseValue;
            return response;
        }
    }
}
