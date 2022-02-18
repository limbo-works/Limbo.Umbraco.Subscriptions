using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.DataAccess.Models;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.Models {
    public class ApiKey : GenericId {
        public int Id { get; set; }
        public string Key { get; set; }
        public virtual ICollection<ApiClaim> Claims { get; set; }

        public List<Claim> GetClaims() {
            return Claims.Select(claim => claim.GetClaim()).ToList();
        }
    }
}
