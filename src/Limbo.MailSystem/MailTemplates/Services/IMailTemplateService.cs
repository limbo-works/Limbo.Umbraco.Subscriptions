using Limbo.EntityFramework.Services.Crud;
using Limbo.MailSystem.Persistence.MailTemplates.Models;
using Limbo.MailSystem.Persistence.MailTemplates.Repositories;

namespace Limbo.MailSystem.MailTemplates.Services {
    /// <summary>
    /// A service for manaing mail templates
    /// </summary>
    public interface IMailTemplateService : ICrudServiceBase<MailTemplate, IMailTemplateRepository> {
    }
}
