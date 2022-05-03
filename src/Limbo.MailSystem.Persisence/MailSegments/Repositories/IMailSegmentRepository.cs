using Limbo.EntityFramework.Repositories.Crud;
using Limbo.MailSystem.Persisence.MailSegments.Models;

namespace Limbo.MailSystem.Persisence.MailSegments.Repositories {
    /// <summary>
    /// A repository for managing mail segments
    /// </summary>
    public interface IMailSegmentRepository : IDbCrudRepositoryBase<MailSegment> {
    }
}