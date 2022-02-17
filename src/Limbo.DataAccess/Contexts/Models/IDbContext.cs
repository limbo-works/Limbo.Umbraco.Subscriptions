using Microsoft.EntityFrameworkCore;

namespace Limbo.DataAccess.Contexts.Models {
    public interface IDbContext {
        public DbContext Context { get; }
    }
}