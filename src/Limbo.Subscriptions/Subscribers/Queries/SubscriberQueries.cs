using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Subscribers.Services;
using HotChocolate.Types;
using Limbo.Subscriptions.Bases.GraphQL.Queries;
using System.Data;

namespace Limbo.Subscriptions.Subscribers.Queries {

    [ExtendObjectType(typeof(Query))]
    public class SubscriberQueries {

        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<Subscriber>> GetSubscribers([Service] ISubscriberService subscriberService) {
            var response = (await subscriberService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            if (response is not null) {
                return response;
            } else {
                return Enumerable.Empty<Subscriber>().AsQueryable();
            }
        }

        [UseFirstOrDefault]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<Subscriber>> GetSubscriber([Service] ISubscriberService subscriberService) {
            var response = (await subscriberService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            return response;
        }
    }
}
