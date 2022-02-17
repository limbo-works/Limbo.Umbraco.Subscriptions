using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate.Types;
using HotChocolate;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.NewsletterQueues.Services;
using Limbo.Subscriptions.Bases.GraphQL.Queries;
using System.Data;

namespace Limbo.Subscriptions.NewsletterQueues.Queries {
    [ExtendObjectType(typeof(Query))]
    public class NewsletterQueueQueries {
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<NewsletterQueue>> GetNewsLetterQueues([Service] INewsletterQueueService newsletterQueueService) {
            var response = (await newsletterQueueService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            if (response is not null) {
                return response;
            } else {
                return Enumerable.Empty<NewsletterQueue>().AsQueryable();
            }
        }

        [UseFirstOrDefault]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<NewsletterQueue>> GetNewsletterQueueById([Service] INewsletterQueueService newsletterQueueService) {
            var response = (await newsletterQueueService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            return response;
        }
    }
}
