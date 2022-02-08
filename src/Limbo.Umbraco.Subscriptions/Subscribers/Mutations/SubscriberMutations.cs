using System;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Types;
using Limbo.Umbraco.Subscription.Persistence.Subscribers.Models;
using Limbo.Umbraco.Subscriptions.Bases.GraphQL.Mutations;
using Limbo.Umbraco.Subscriptions.Subscribers.Services;

namespace Limbo.Umbraco.Subscriptions.Subscribers.Mutations {
    [ExtendObjectType(typeof(Mutation))]
    public class SubscriberMutations {
        public async Task<Subscriber> CreateSubscriber([Service] ISubscriberService subscriberService, string name, string email, DateTime created, bool isConfirmed) {
            return (await subscriberService.Add(new Subscriber { Name = name, Email = email, Created = created, IsConfirmed = isConfirmed })).ReponseValue;
        }
    }
}
