using Limbo.DataAccess.Services.Crud;
using Limbo.MailSystem.Persisence.MailSegments.Models;
using Limbo.MailSystem.Persisence.MailSegments.Repositories;

namespace Limbo.MailSystem.MailSegments.Services {
    /// <summary>
    /// A service for manaing amil segments
    /// </summary>
    public interface IMailSegmentService : ICrudServiceBase<MailSegment, IMailSegmentRepository> {
    }
}