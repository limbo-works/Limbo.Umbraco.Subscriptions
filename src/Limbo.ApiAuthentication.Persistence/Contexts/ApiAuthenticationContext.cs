using System.Reflection;
using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Microsoft.EntityFrameworkCore;

namespace Limbo.ApiAuthentication.Persistence.Contexts {
    /// <inheritdoc/>
    public class ApiAuthenticationContext : DbContext, IApiAuthenticationContext {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public ApiAuthenticationContext(DbContextOptions<ApiAuthenticationContext> options) : base(options) {
        }

        /// <inheritdoc/>
        public DbContext Context => this;
        /// <summary>
        /// Api keys
        /// </summary>
        public DbSet<ApiKey> ApiKeys { get; set; }

        /// <summary>
        /// Api claims
        /// </summary>
        public DbSet<ApiClaim> ApiClaims { get; set; }

        /// <summary>
        /// Adds configuration
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
