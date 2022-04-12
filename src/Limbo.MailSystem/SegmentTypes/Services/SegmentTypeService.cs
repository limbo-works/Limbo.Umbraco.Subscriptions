using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Settings;
using Limbo.DataAccess.UnitOfWorks;
using Limbo.MailSystem.Persisence.SegmentTypes.Models;
using Limbo.MailSystem.Persisence.SegmentTypes.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.SegmentTypes.Services {
    /// <inheritdoc/>
    public class SegmentTypeService : CrudServiceBase<SegmentType, ISegmentTypeRepository>, ISegmentTypeService {
        /// <inheritdoc/>
        public SegmentTypeService(ISegmentTypeRepository repository, ILogger<ServiceBase<ISegmentTypeRepository>> logger, DataAccessSettings dataAccessSettings, IUnitOfWork<ISegmentTypeRepository> unitOfWork) : base(repository, logger, dataAccessSettings, unitOfWork) {
        }
    }
}
