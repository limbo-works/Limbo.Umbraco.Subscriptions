using System.Data;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Data;
using HotChocolate.Types;
using Limbo.Subscriptions.NewsletterQueues.Services;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;

namespace Limbo.Subscriptions.NewsletterQueues.Queries {
    public class NewsletterQueueQueriesBase {

        [Authorize]
        [UseFirstOrDefault]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<NewsletterQueue>?> GetNewsletterQueueById([Service] INewsletterQueueService newsletterQueueService) {
            var response = (await newsletterQueueService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            return response;
        }
        [Authorize]
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<NewsletterQueue>> GetNewsLetterQueues([Service] INewsletterQueueService newsletterQueueService) {
            var response = (await newsletterQueueService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            if (response is not null) {
                return response;
            } else {
                return Enumerable.Empty<NewsletterQueue>().AsQueryable();
            }
        }
    }
}