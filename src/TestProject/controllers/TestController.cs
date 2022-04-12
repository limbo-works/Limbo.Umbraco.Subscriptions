using Umbraco.Cms.Web.Common.Controllers;

namespace TestProject.controllers {
    public class TestController : UmbracoApiController {
        //private readonly IApiKeyAuthenticatorService _authenticationService;
        //private readonly IApiKeyService _apiKeyService;

        //public TestController(IApiKeyAuthenticatorService authenticationService, IApiKeyService apiKeyService) {
        //    _authenticationService = authenticationService;
        //    _apiKeyService = apiKeyService;
        //}

        //[HttpGet]
        //public async Task<ApiToken> Authenticate(string apiKey) {
        //    return await _authenticationService.AuthenticateKey(apiKey);
        //}

        //[HttpGet]
        //[Authorize]
        //public async Task<ApiKey> CreateApiKey(string apiKey) {
        //    return (await _apiKeyService.Add(new ApiKey { Key = apiKey })).ResponseValue;
        //}
    }
}
