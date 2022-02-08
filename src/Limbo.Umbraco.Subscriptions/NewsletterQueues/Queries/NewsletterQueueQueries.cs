using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate.Types;
using HotChocolate;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models;
using Limbo.Umbraco.Subscriptions.SubscriptionSystems.Services;
using Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models;
using Limbo.Umbraco.Subscriptions.NewsletterQueues.Services;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL;

namespace Limbo.Umbraco.Subscriptions.NewsletterQueues.Queries {
    [ExtendObjectType(typeof(Query))]
    public class NewsletterQueueQueries {
        [UseDbContext(typeof(SubscriptionDbContext))]
        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<NewsletterQueue>> GetNewsLetterQueues([Service] INewsletterQueueService newsletterQueueService) {
            var response = (await newsletterQueueService.GetAll()).ReponseValue;
            if (response is not null) {
                return response.ToList();
            } else {
                return Enumerable.Empty<NewsletterQueue>();
            }
        }

        [UseDbContext(typeof(SubscriptionDbContext))]
        [UseFiltering]
        [UseSorting]
        public async Task<NewsletterQueue> GetNewsletterQueueById([Service] INewsletterQueueService newsletterQueueService, int id) {
            var response = (await newsletterQueueService.GetById(id)).ReponseValue;
            return response;
        }
    }
}
