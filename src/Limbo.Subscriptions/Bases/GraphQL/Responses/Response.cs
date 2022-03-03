using System;
using Limbo.DataAccess.Services.Models;

namespace Limbo.Subscriptions.Bases.GraphQL.Responses {
    public static class Response {
        public static T? CreateResponse<T>(IServiceResponse<T> response)
            where T : class, new() {
            return response.StatusCode switch {
                System.Net.HttpStatusCode.InternalServerError => throw new Exception("Internal server error"),
                System.Net.HttpStatusCode.NoContent => null,
                _ => response.ReponseValue,
            };
        }
    }
}
