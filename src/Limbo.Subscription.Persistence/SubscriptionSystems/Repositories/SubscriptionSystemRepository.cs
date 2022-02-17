using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.Contexts;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.Repositories {
    public class SubscriptionSystemRepository : DbCrudRepositoryBase<SubscriptionSystem>, ISubscriptionSystemRepository {
        public SubscriptionSystemRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<SubscriptionSystem>> logger) : base(dbContext, logger) {
        }
    }
}
