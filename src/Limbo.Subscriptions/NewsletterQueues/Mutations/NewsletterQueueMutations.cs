using HotChocolate.Types;
using Limbo.Subscriptions.Bases.GraphQL.Mutations;

namespace Limbo.Subscriptions.NewsletterQueues.Mutations {
    [ExtendObjectType(typeof(Mutation))]
    public class NewsletterQueueMutations : NewsletterQueueMutationsBase {
    }
}
