using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscription.Persistence.Categories.Repositories {
    public class CategoryRepository : DbCrudRepositoryBase<Category>, ICategoryRepository {
        public CategoryRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<Category>> logger) : base(dbContext, logger) {
        }
    }
}
