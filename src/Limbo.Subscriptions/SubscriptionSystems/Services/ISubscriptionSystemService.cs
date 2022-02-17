using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Repositories;
using Limbo.DataAccess.Services.Crud;

namespace Limbo.Subscriptions.SubscriptionSystems.Services {
    public interface ISubscriptionSystemService : ICrudServiceBase<SubscriptionSystem, ISubscriptionSystemRepository> {
    }
}