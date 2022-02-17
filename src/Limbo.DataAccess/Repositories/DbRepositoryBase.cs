using Limbo.DataAccess.Contexts.Models;
using Microsoft.EntityFrameworkCore;

namespace Limbo.DataAccess.Repositories {
    public abstract class DbRepositoryBase : IDbRepository {
        private readonly DbContext _context;

        public DbRepositoryBase(IDbContext context) {
            _context = context.Context;
        }

        /// <inheritdoc/>
        public virtual DbContext GetDBContext() {
            return _context;
        }
    }
}
