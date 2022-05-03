using Limbo.EntityFramework.Repositories.Crud;
using Limbo.MailSystem.Persistence.MailSegments.Models;

namespace Limbo.MailSystem.Persistence.MailSegments.Repositories {
    /// <summary>
    /// A repository for managing mail segments
    /// </summary>
    public interface IMailSegmentRepository : IDbCrudRepositoryBase<MailSegment> {
    }
}