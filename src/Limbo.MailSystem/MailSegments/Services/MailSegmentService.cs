using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Settings;
using Limbo.DataAccess.UnitOfWorks;
using Limbo.MailSystem.Persisence.MailSegments.Models;
using Limbo.MailSystem.Persisence.MailSegments.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.MailSegments.Services {
    /// <inheritdoc/>
    public class MailSegmentService : CrudServiceBase<MailSegment, IMailSegmentRepository>, IMailSegmentService {
        /// <inheritdoc/>
        public MailSegmentService(IMailSegmentRepository repository, ILogger<ServiceBase<IMailSegmentRepository>> logger, DataAccessSettings dataAccessSettings, IUnitOfWork<IMailSegmentRepository> unitOfWork) : base(repository, logger, dataAccessSettings, unitOfWork) {
        }
    }
}
