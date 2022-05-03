using Limbo.EntityFramework.Services.Crud;
using Limbo.MailSystem.Persistence.SegmentTypes.Models;
using Limbo.MailSystem.Persistence.SegmentTypes.Repositories;

namespace Limbo.MailSystem.SegmentTypes.Services {
    /// <summary>
    /// A service for managing segment types
    /// </summary>
    public interface ISegmentTypeService : ICrudServiceBase<SegmentType, ISegmentTypeRepository> {
    }
}
