using Limbo.EntityFramework.Repositories.Crud;
using Limbo.MailSystem.Persistence.Contexts;
using Limbo.MailSystem.Persistence.SegmentTypes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.Persistence.SegmentTypes.Repositories {
    /// <inheritdoc/>
    public class SegmentTypeRepository : DbCrudRepositoryBase<SegmentType>, ISegmentTypeRepository {
        /// <inheritdoc/>
        public SegmentTypeRepository(IDbContextFactory<MailContext> contextFactory, ILogger<DbCrudRepositoryBase<SegmentType>> logger) : base(contextFactory, logger) {
        }
    }
}
