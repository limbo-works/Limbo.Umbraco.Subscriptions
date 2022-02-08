using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL;
using Limbo.Umbraco.Subscriptions.Subscribers.Services;
using Limbo.Umbraco.Subscriptions.Categories.Services;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;

namespace Limbo.Umbraco.Subscriptions.Categories.Queries {

    [ExtendObjectType(typeof(Query))]
    public class CategoryQueries {
        [UseDbContext(typeof(SubscriptionDbContext))]
        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<Category>> GetCategories([Service] ICategoryService categoryService) {
            var response = (await categoryService.GetAll()).ReponseValue;
            if (response is not null) {
                return response.ToList();
            } else {
                return Enumerable.Empty<Category>();
            }
        }

        [UseDbContext(typeof(SubscriptionDbContext))]
        [UseFiltering]
        [UseSorting]
        public async Task<Category> GetCategoryById([Service] ICategoryService categoryService, int id) {
            var response = (await categoryService.GetById(id)).ReponseValue;
            return response;
        }
    }
}
