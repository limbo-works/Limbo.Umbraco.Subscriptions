using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;

namespace Limbo.Subscriptions.Persistence.SubscriptionItems.Models {
    public class SubscriptionItem : GenericId {
        public int Id { get; set; }
        public int NodeId { get; set; }

        public virtual List<Category> Categories { get; set; }
        public virtual List<Subscriber> Subscribers { get; set; }
        public virtual List<NewsletterQueue> NewsletterQueues { get; set; }
    }
}
