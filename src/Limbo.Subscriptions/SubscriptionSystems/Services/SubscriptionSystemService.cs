using System.Threading.Tasks;
using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Services.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.SubscriptionSystems.Services {
    public class SubscriptionSystemService : CrudServiceBase<SubscriptionSystem, ISubscriptionSystemRepository>, ISubscriptionSystemService {
        public SubscriptionSystemService(ISubscriptionSystemRepository repository, ILogger<ServiceBase<ISubscriptionSystemRepository>> logger) : base(repository, logger) {
        }

        public override Task<IServiceResponse<SubscriptionSystem>> Add(SubscriptionSystem entity) {
            SubscriptionSystem.Validate(entity);
            return base.Add(entity);
        }

        public override Task<IServiceResponse<SubscriptionSystem>> Update(SubscriptionSystem entity) {
            SubscriptionSystem.Validate(entity);
            return base.Update(entity);
        }
    }
}
