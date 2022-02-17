using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Subscriptions.Persistence.Contexts;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Limbo.Subscriptions.SubscriptionSystems.Services;
using Limbo.Subscriptions.Bases.GraphQL.Queries;

namespace Limbo.Subscriptions.SubscriptionSystems.Queries {
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
