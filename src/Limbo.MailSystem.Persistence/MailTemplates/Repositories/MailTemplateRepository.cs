using Limbo.EntityFramework.Repositories.Crud;
using Limbo.MailSystem.Persistence.Contexts;
using Limbo.MailSystem.Persistence.MailTemplates.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Limbo.MailSystem.Persistence.MailTemplates.Repositories {
    /// <inheritdoc/>
    public class MailTemplateRepository : DbCrudRepositoryBase<MailTemplate>, IMailTemplateRepository {
        /// <inheritdoc/>
        public MailTemplateRepository(IDbContextFactory<MailContext> contextFactory, ILogger<DbCrudRepositoryBase<MailTemplate>> logger) : base(contextFactory, logger) {
        }
    }
}
