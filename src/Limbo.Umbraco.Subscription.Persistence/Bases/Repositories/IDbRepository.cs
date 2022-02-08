using Microsoft.EntityFrameworkCore;

namespace Limbo.Umbraco.Subscription.Persistence.Bases.Repositories {
    public interface IDbRepository {
        /// <summary>
        /// Gets the db context
        /// </summary>
        /// <returns></returns>
        DbContext GetDBContext();
    }
}