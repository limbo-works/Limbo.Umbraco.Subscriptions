using Limbo.EntityFramework.Services;
using Limbo.EntityFramework.Services.Crud;
using Limbo.EntityFramework.Settings;
using Limbo.EntityFramework.UnitOfWorks;
using Limbo.MailSystem.Persisence.MailTemplates.Models;
using Limbo.MailSystem.Persisence.MailTemplates.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.MailTemplates.Services {
    /// <inheritdoc/>
    public class MailTemplateService : CrudServiceBase<MailTemplate, IMailTemplateRepository>, IMailTemplateService {
        /// <inheritdoc/>
        public MailTemplateService(IMailTemplateRepository repository, ILogger<ServiceBase<IMailTemplateRepository>> logger, EntityFrameworkSettings entityFrameworkSettings, IUnitOfWork<IMailTemplateRepository> unitOfWork) : base(repository, logger, entityFrameworkSettings, unitOfWork) {
        }
    }
}
