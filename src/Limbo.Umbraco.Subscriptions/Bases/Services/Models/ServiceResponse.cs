using System.Net;

namespace Limbo.Umbraco.Subscriptions.Bases.Services.Models {
    public class ServiceResponse<T> : IServiceResponse<T> where T : class {
        public ServiceResponse(HttpStatusCode statusCode, T reponse) {
            StatusCode = statusCode;
            ReponseValue = reponse;
        }

        public HttpStatusCode StatusCode { get; set; }
        public T ReponseValue { get; set; }
    }
}
