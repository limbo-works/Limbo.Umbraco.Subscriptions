using System.Threading.Tasks;
using AutoMapper;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL.Mutations;
using Limbo.Umbraco.Subscriptions.Categories.Services;

namespace Limbo.Umbraco.Subscriptions.Categories.Mutations {
    [ExtendObjectType(typeof(Mutation))]
    public class CategoryMutations {
        public async Task<Category> CreateCategory([Service] ICategoryService categoryService, string categoryName) {
            return (await categoryService.Add(new Category { Name = categoryName })).ReponseValue;
        }

        public async Task<Category> DeleteCategoryById([Service] ICategoryService categoryService, int categoryId) {
            return (await categoryService.DeleteById(categoryId)).ReponseValue;
        }

        public async Task<Category> UpdateCategory([Service] ICategoryService categoryService, [Service] IMapper mapper, Category category) {
            return (await categoryService.Update(category)).ReponseValue;
        }
    }
}
