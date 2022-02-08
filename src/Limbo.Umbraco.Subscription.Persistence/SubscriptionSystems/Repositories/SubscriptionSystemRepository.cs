using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Repositories {
    public class SubscriptionSystemRepository : DbCrudRepositoryBase<SubscriptionSystem>, ISubscriptionSystemRepository {
        public SubscriptionSystemRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<SubscriptionSystem>> logger) : base(dbContext, logger) {
        }
    }
}
