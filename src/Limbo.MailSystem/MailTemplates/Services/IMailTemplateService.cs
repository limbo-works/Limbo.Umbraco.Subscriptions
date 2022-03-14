using Limbo.DataAccess.Services.Crud;
using Limbo.MailSystem.Persisence.MailTemplates.Models;
using Limbo.MailSystem.Persisence.MailTemplates.Repositories;

namespace Limbo.MailSystem.MailTemplates.Services {
    /// <summary>
    /// A service for manaing mail templates
    /// </summary>
    public interface IMailTemplateService : ICrudServiceBase<MailTemplate, IMailTemplateRepository> {
    }
}
