using Limbo.EntityFramework.Repositories.Crud;
using Limbo.MailSystem.Persisence.MailTemplates.Models;

namespace Limbo.MailSystem.Persisence.MailTemplates.Repositories {
    /// <summary>
    /// A repository for manaing mail templates
    /// </summary>
    public interface IMailTemplateRepository : IDbCrudRepositoryBase<MailTemplate> {
    }
}