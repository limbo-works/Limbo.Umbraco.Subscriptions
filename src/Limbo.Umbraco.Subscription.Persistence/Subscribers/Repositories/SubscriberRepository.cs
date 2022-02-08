using Limbo.Umbraco.Subscription.Persistence.Bases.Repositories.Crud;
using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.Umbraco.Subscription.Persistence.Subscribers.Repositories {
    public class SubscriberRepository : DbCrudRepositoryBase<Subscriber>, ISubscriberRepository {
        public SubscriberRepository(ISubscriptionDbContext dbContext, ILogger<DbCrudRepositoryBase<Subscriber>> logger) : base(dbContext, logger) {
        }
    }
}
