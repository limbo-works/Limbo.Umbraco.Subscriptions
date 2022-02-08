using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Limbo.Umbraco.Subscription.Persistence.Bases.Repositories {
    public abstract class DbRepositoryBase : IDbRepository {
        private readonly DbContext _context;

        public DbRepositoryBase(ISubscriptionDbContext context) {
            _context = context.Context;
        }

        /// <inheritdoc/>
        public virtual DbContext GetDBContext() {
            return _context;
        }
    }
}
