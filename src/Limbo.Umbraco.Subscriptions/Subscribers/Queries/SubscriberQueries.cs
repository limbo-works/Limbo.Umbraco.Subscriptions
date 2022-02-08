using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Limbo.Umbraco.Subscriptions.Subscribers.Services;
using HotChocolate.Types;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL;

namespace Limbo.Umbraco.Subscriptions.Subscribers.Queries {

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
