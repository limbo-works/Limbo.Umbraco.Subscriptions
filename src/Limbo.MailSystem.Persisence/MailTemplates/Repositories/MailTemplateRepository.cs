using Limbo.DataAccess.Repositories.Crud;
using Limbo.MailSystem.Persisence.Contexts;
using Limbo.MailSystem.Persisence.MailTemplates.Models;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.Persisence.MailTemplates.Repositories {
    /// <inheritdoc/>
    public class MailTemplateRepository : DbCrudRepositoryBase<MailTemplate>, IMailTemplateRepository {
        /// <inheritdoc/>
        protected MailTemplateRepository(IMailContext dbContext, ILogger<DbCrudRepositoryBase<MailTemplate>> logger) : base(dbContext, logger) {
        }
    }
}
