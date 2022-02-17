using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.Models {
    public class NewsletterQueue : GenericId {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<SubscriptionItem> SubscriptionItems { get; set; }
    }
}
