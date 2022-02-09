using System;
using Limbo.Umbraco.Subscriptions.Bases.Services.Models;

namespace Limbo.Umbraco.Subscriptions.Bases.GraphQL.Responses {
    public static class Response {
        public static T CreateResponse<T>(IServiceResponse<T> response)
            where T : class {
            return response.StatusCode switch {
                System.Net.HttpStatusCode.InternalServerError => throw new Exception("Internal server error"),
                System.Net.HttpStatusCode.NoContent => null,
                _ => response.ReponseValue,
            };
        }
    }
}
