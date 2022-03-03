using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Subscriptions.Categories.Services;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Bases.GraphQL.Queries;
using System.Data;
using HotChocolate.AspNetCore.Authorization;

namespace Limbo.Subscriptions.Categories.Queries {

    [ExtendObjectType(typeof(Query))]
    public class CategoryQueries {
        [Authorize]
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<Category>> GetCategories([Service] ICategoryService categoryService) {
            var response = (await categoryService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            if (response is not null) {
                return response;
            } else {
                return Enumerable.Empty<Category>().AsQueryable();
            }
        }

        [Authorize]
        [UseFirstOrDefault]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<Category>?> GetCategory([Service] ICategoryService categoryService) {
            var response = (await categoryService.QueryDbSet(IsolationLevel.ReadCommitted)).ReponseValue;
            return response;
        }
    }
}
