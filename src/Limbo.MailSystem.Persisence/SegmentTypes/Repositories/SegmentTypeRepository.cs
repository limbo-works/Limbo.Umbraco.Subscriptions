using Limbo.EntityFramework.Repositories.Crud;
using Limbo.MailSystem.Persisence.Contexts;
using Limbo.MailSystem.Persisence.SegmentTypes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.Persisence.SegmentTypes.Repositories {
    /// <inheritdoc/>
    public class SegmentTypeRepository : DbCrudRepositoryBase<SegmentType>, ISegmentTypeRepository {
        /// <inheritdoc/>
        public SegmentTypeRepository(IDbContextFactory<MailContext> contextFactory, ILogger<DbCrudRepositoryBase<SegmentType>> logger) : base(contextFactory, logger) {
        }
    }
}
