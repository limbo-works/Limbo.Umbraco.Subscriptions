using Limbo.EntityFramework.Repositories.Crud;
using Limbo.MailSystem.Persistence.MailTemplates.Models;

namespace Limbo.MailSystem.Persistence.MailTemplates.Repositories {
    /// <summary>
    /// A repository for manaing mail templates
    /// </summary>
    public interface IMailTemplateRepository : IDbCrudRepositoryBase<MailTemplate> {
    }
}