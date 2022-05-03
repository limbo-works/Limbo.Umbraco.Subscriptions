using Limbo.EntityFramework.Services;
using Limbo.EntityFramework.Services.Crud;
using Limbo.EntityFramework.Settings;
using Limbo.EntityFramework.UnitOfWorks;
using Limbo.MailSystem.Persisence.MailSegments.Models;
using Limbo.MailSystem.Persisence.MailSegments.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.MailSegments.Services {
    /// <inheritdoc/>
    public class MailSegmentService : CrudServiceBase<MailSegment, IMailSegmentRepository>, IMailSegmentService {
        /// <inheritdoc/>
        public MailSegmentService(IMailSegmentRepository repository, ILogger<ServiceBase<IMailSegmentRepository>> logger, EntityFrameworkSettings entityFrameworkSettings, IUnitOfWork<IMailSegmentRepository> unitOfWork) : base(repository, logger, entityFrameworkSettings, unitOfWork) {
        }
    }
}
