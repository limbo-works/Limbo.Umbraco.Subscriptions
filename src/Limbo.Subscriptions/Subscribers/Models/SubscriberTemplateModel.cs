using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.MailSystem.Templates.RazorTemplates.Builders;

namespace Limbo.Subscriptions.Subscribers.Models {
    public class SubscriberTemplateModel : Subscriber, ITemplateModel {
        public SubscriberTemplateModel(Subscriber subscriber) {
            Id = subscriber.Id;
            Name = subscriber.Name;
            Email = subscriber.Email;
            IsConfirmed = subscriber.IsConfirmed;
            Created = subscriber.Created;
            SubscriptionItems = subscriber.SubscriptionItems;
            SubscriptionSystem = subscriber.SubscriptionSystem;
            Categories = subscriber.Categories;
        }
    }
}
