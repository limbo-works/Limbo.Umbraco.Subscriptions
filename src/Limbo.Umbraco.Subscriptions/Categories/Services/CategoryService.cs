using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscription.Persistence.Categories.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscriptions.Categories.Services {
    public class CategoryService : CrudServiceBase<Category, ICategoryRepository>, ICategoryService {
        public CategoryService(ICategoryRepository repository, ILogger<ServiceBase<ICategoryRepository>> logger) : base(repository, logger) {
        }
    }
}
