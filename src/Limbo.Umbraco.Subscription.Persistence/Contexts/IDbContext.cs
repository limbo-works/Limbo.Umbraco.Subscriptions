using Microsoft.EntityFrameworkCore;

namespace Limbo.Umbraco.Subscription.Persistence.Contexts {
    public interface IDbContext {
        DbContext Context { get; }
    }
}
