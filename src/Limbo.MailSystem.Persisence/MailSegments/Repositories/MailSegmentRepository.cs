using Limbo.DataAccess.Repositories.Crud;
using Limbo.MailSystem.Persisence.Contexts;
using Limbo.MailSystem.Persisence.MailSegments.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.Persisence.MailSegments.Repositories {
    /// <inheritdoc/>
    public class MailSegmentRepository : DbCrudRepositoryBase<MailSegment>, IMailSegmentRepository {
        /// <inheritdoc/>
        public MailSegmentRepository(IMailContext dbContext, ILogger<DbCrudRepositoryBase<MailSegment>> logger) : base(dbContext, logger) {
        }
    }
}
