using System.Net;

namespace Limbo.DataAccess.Services.Models {
    public interface IServiceResponse<T> where T : class {
        T ReponseValue { get; set; }
        HttpStatusCode StatusCode { get; set; }
    }
}
