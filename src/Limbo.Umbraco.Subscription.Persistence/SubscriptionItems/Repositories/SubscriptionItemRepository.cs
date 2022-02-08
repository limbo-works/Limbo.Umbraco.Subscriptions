using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Repositories {
    public class SubscriptionItemRepository : DbCrudRepositoryBase<SubscriptionItem>, ISubscriptionItemRepository {
        public SubscriptionItemRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<SubscriptionItem>> logger) : base(dbContext, logger) {
        }
    }
}
