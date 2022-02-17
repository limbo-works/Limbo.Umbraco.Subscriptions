using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate;
using Limbo.Subscriptions.Persistence.Contexts;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Subscribers.Services;
using HotChocolate.Types;
using Limbo.Subscriptions.Bases.GraphQL.Queries;

namespace Limbo.Subscriptions.Subscribers.Queries {

    [ExtendObjectType(typeof(Query))]
    public class SubscriberQueries {
        [UseDbContext(typeof(SubscriptionDbContext))]
        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<Subscriber>> GetSubscribers([Service] ISubscriberService subscriberService) {
            var response = (await subscriberService.GetAll()).ReponseValue;
            if (response is not null) {
                return response.ToList();
            } else {
                return Enumerable.Empty<Subscriber>();
            }
        }

        [UseDbContext(typeof(SubscriptionDbContext))]
        [UseFiltering]
        [UseSorting]
        public async Task<Subscriber> GetSubscriberById([Service] ISubscriberService subscriberService, int id) {
            var response = (await subscriberService.GetById(id)).ReponseValue;
            return response;
        }
    }
}
