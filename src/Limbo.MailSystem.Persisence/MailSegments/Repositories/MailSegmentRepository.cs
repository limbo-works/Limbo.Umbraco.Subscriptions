using Limbo.DataAccess.Repositories.Crud;
using Limbo.MailSystem.Persisence.Contexts;
using Limbo.MailSystem.Persisence.MailSegments.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.Persisence.MailSegments.Repositories {
    /// <inheritdoc/>
    public class MailSegmentRepository : DbCrudRepositoryBase<MailSegment>, IMailSegmentRepository {
        /// <inheritdoc/>
        public MailSegmentRepository(IDbContextFactory<MailContext> contextFactory, ILogger<DbCrudRepositoryBase<MailSegment>> logger) : base(contextFactory, logger) {
        }
    }
}
