using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.DataAccess.Models;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.Models {
    /// <summary>
    /// A api key
    /// </summary>
    public class ApiKey : GenericId {
        /// <summary>
        /// The id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The api key
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// The claims of the api key
        /// </summary>
        public virtual ICollection<ApiClaim> Claims { get; set; }

        /// <summary>
        /// Gets the claims as <see cref="Claim"/>
        /// </summary>
        /// <returns></returns>
        public List<Claim> GetClaims() {
            return Claims.Select(claim => claim.GetClaim()).ToList();
        }
    }
}
