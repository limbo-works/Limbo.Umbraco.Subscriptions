using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models;
using Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Repositories;
using Limbo.Umbraco.Subscriptions.Bases.Services.Crud;

namespace Limbo.Umbraco.Subscriptions.SubscriptionSystems.Services {
    public interface ISubscriptionSystemService : ICrudServiceBase<SubscriptionSystem, ISubscriptionSystemRepository> {
    }
}