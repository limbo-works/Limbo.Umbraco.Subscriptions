using Limbo.DataAccess.Repositories.Crud;
using Limbo.MailSystem.Persisence.Contexts;
using Limbo.MailSystem.Persisence.SegmentTypes.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.Persisence.SegmentTypes.Repositories {
    /// <inheritdoc/>
    public class SegmentTypeRepository : DbCrudRepositoryBase<SegmentType>, ISegmentTypeRepository {
        /// <inheritdoc/>
        public SegmentTypeRepository(IMailContext dbContext, ILogger<DbCrudRepositoryBase<SegmentType>> logger) : base(dbContext, logger) {
        }
    }
}
