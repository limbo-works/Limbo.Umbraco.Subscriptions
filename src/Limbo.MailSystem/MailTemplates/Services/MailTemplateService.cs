using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Settings;
using Limbo.DataAccess.UnitOfWorks;
using Limbo.MailSystem.Persisence.MailTemplates.Models;
using Limbo.MailSystem.Persisence.MailTemplates.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.MailTemplates.Services {
    /// <inheritdoc/>
    public class MailTemplateService : CrudServiceBase<MailTemplate, IMailTemplateRepository>, IMailTemplateService {
        /// <inheritdoc/>
        public MailTemplateService(IMailTemplateRepository repository, ILogger<ServiceBase<IMailTemplateRepository>> logger, DataAccessSettings dataAccessSettings, IUnitOfWork<IMailTemplateRepository> unitOfWork) : base(repository, logger, dataAccessSettings, unitOfWork) {
        }
    }
}
