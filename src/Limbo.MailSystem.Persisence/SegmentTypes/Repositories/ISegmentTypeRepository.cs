using Limbo.DataAccess.Repositories.Crud;
using Limbo.MailSystem.Persisence.SegmentTypes.Models;

namespace Limbo.MailSystem.Persisence.SegmentTypes.Repositories {
    /// <summary>
    /// A repository for managing segment types
    /// </summary>
    public interface ISegmentTypeRepository : IDbCrudRepositoryBase<SegmentType> {
    }
}