using Limbo.EntityFramework.Repositories.Crud;
using Limbo.MailSystem.Persisence.Contexts;
using Limbo.MailSystem.Persisence.MailTemplates.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.Persisence.MailTemplates.Repositories {
    /// <inheritdoc/>
    public class MailTemplateRepository : DbCrudRepositoryBase<MailTemplate>, IMailTemplateRepository {
        /// <inheritdoc/>
        public MailTemplateRepository(IDbContextFactory<MailContext> contextFactory, ILogger<DbCrudRepositoryBase<MailTemplate>> logger) : base(contextFactory, logger) {
        }
    }
}
