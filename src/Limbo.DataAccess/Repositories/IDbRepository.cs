using Microsoft.EntityFrameworkCore;

namespace Limbo.DataAccess.Repositories {
    public interface IDbRepository {
        /// <summary>
        /// Gets the db context
        /// </summary>
        /// <returns></returns>
        DbContext GetDBContext();
    }
}