using Limbo.Umbraco.Subscription.Persistence.Contexts;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.Controllers;

namespace TestProject {
    public class TestController : UmbracoApiController {

        private readonly ISubscriptionDbContext _subscriptionDbContext;

        public TestController(ISubscriptionDbContext subscriptionDbContext) {
            _subscriptionDbContext = subscriptionDbContext;
        }

        [HttpGet]
        public IActionResult Test() {
            return null;
        }
    }
}
