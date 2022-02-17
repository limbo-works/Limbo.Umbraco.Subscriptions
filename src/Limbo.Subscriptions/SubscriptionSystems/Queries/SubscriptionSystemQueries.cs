using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Limbo.Subscriptions.SubscriptionSystems.Services;
using Limbo.Subscriptions.Bases.GraphQL.Queries;
using System.Data;

namespace Limbo.Subscriptions.SubscriptionSystems.Queries {
    [ExtendObjectType(typeof(Query))]
    public class SubscriptionSystemQueries {
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<SubscriptionSystem>> GetSubscriptionSystems([Service] ISubscriptionSystemService subscriptionSystemService) {
            var response = (await subscriptionSystemService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            if (response is not null) {
                return response;
            } else {
                return Enumerable.Empty<SubscriptionSystem>().AsQueryable();
            }
        }

        [UseFirstOrDefault]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<SubscriptionSystem>> GetSubscriptionSystemById([Service] ISubscriptionSystemService subscriptionSystemService) {
            var response = (await subscriptionSystemService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            return response;
        }
    }
}
