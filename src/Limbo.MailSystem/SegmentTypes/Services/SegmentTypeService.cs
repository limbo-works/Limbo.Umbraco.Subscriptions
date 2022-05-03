using Limbo.EntityFramework.Services;
using Limbo.EntityFramework.Services.Crud;
using Limbo.EntityFramework.Settings;
using Limbo.EntityFramework.UnitOfWorks;
using Limbo.MailSystem.Persistence.SegmentTypes.Models;
using Limbo.MailSystem.Persistence.SegmentTypes.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.SegmentTypes.Services {
    /// <inheritdoc/>
    public class SegmentTypeService : CrudServiceBase<SegmentType, ISegmentTypeRepository>, ISegmentTypeService {
        /// <inheritdoc/>
        public SegmentTypeService(ISegmentTypeRepository repository, ILogger<ServiceBase<ISegmentTypeRepository>> logger, EntityFrameworkSettings entityFrameworkSettings, IUnitOfWork<ISegmentTypeRepository> unitOfWork) : base(repository, logger, entityFrameworkSettings, unitOfWork) {
        }
    }
}
