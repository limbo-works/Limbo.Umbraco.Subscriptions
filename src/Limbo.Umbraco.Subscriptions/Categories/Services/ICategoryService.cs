using Limbo.Umbraco.Subscription.Persistence.Categories.Models;
using Limbo.Umbraco.Subscription.Persistence.Categories.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;

namespace Limbo.Umbraco.Subscriptions.Categories.Services {
    public interface ICategoryService : ICrudServiceBase<Category, ICategoryRepository> {
    }
}
