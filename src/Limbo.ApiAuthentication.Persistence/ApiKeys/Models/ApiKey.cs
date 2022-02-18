using Limbo.DataAccess.Models;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.Models {
    public class ApiKey : GenericId {
        public int Id { get; set; }
        public string Key { get; set; }
    }
}
