using Microsoft.EntityFrameworkCore;

namespace Limbo.DataAccess.Repositories {
    public interface IDbRepositoryBase {
        /// <summary>
        /// Gets the db context
        /// </summary>
        /// <returns></returns>
        DbContext GetDBContext();
    }
}