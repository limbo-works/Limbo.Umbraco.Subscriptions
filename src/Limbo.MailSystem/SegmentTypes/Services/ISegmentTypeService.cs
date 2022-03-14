using Limbo.DataAccess.Services.Crud;
using Limbo.MailSystem.Persisence.SegmentTypes.Models;
using Limbo.MailSystem.Persisence.SegmentTypes.Repositories;

namespace Limbo.MailSystem.SegmentTypes.Services {
    /// <summary>
    /// A service for managing segment types
    /// </summary>
    public interface ISegmentTypeService : ICrudServiceBase<SegmentType, ISegmentTypeRepository> {
    }
}
