﻿using HotChocolate.Types;
using Limbo.Subscriptions.Bases.GraphQL.Mutations;

namespace Limbo.Subscriptions.Subscribers.Mutations {
    [ExtendObjectType(typeof(Mutation))]
    public class SubscriberMutations : SubscriberMutationsBase {
    }
}
