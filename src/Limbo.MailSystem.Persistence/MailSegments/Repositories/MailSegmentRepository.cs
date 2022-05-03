using Limbo.EntityFramework.Repositories.Crud;
using Limbo.MailSystem.Persistence.Contexts;
using Limbo.MailSystem.Persistence.MailSegments.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.Persistence.MailSegments.Repositories {
    /// <inheritdoc/>
    public class MailSegmentRepository : DbCrudRepositoryBase<MailSegment>, IMailSegmentRepository {
        /// <inheritdoc/>
        public MailSegmentRepository(IDbContextFactory<MailContext> contextFactory, ILogger<DbCrudRepositoryBase<MailSegment>> logger) : base(contextFactory, logger) {
        }
    }
}
