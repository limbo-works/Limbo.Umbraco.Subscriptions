using Limbo.EntityFramework.Repositories.Crud;
using Limbo.MailSystem.Persistence.SegmentTypes.Models;

namespace Limbo.MailSystem.Persistence.SegmentTypes.Repositories {
    /// <summary>
    /// A repository for managing segment types
    /// </summary>
    public interface ISegmentTypeRepository : IDbCrudRepositoryBase<SegmentType> {
    }
}