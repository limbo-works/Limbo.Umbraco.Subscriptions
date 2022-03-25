using System.Data;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Data;
using HotChocolate.Types;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Subscribers.Services;

namespace Limbo.Subscriptions.Subscribers.Queries {
    public class SubscriberQueriesBase {

        [Authorize]
        [UseFirstOrDefault]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<Subscriber>?> GetSubscriber([Service] ISubscriberService subscriberService) {
            var response = (await subscriberService.QueryDbSet(IsolationLevel.ReadCommitted)).ResponseValue;
            return response;
        }

        [Authorize]
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<Subscriber>> GetSubscribers([Service] ISubscriberService subscriberService) {
            var response = (await subscriberService.QueryDbSet(IsolationLevel.ReadCommitted)).ResponseValue;
            if (response is not null) {
                return response;
            } else {
                return Enumerable.Empty<Subscriber>().AsQueryable();
            }
        }
    }
}