using System.Collections.Generic;
using System.Security.Claims;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.DataAccess.Models;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Models {
    public class ApiClaim : GenericId {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public virtual ICollection<ApiKey> ApiKeys { get; set; }

        public Claim GetClaim() {
            return new Claim(Type, Value);
        }
    }
}
