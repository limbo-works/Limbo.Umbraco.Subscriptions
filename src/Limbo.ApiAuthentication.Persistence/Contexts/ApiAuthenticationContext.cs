using System.Reflection;
using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Microsoft.EntityFrameworkCore;

namespace Limbo.ApiAuthentication.Persistence.Contexts {
    public class ApiAuthenticationContext : DbContext, IApiAuthenticationContext {
        public ApiAuthenticationContext(DbContextOptions<ApiAuthenticationContext> options) : base(options) {
        }

        public DbContext Context => this;
        public DbSet<ApiKey> ApiKeys { get; set; }
        public DbSet<ApiClaim> ApiClaims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
