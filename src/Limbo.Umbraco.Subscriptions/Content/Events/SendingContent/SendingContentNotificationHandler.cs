using System;
using System.Linq;
using Limbo.Umbraco.Subscriptions.Properties;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;

namespace Limbo.Umbraco.Subscriptions.Content.Events.SendingContent {
    internal class SendingContentNotificationHandler : INotificationHandler<SendingContentNotification> {
        public void Handle(SendingContentNotification notification) {
            foreach (var variant in notification.Content.Variants) {
                if (variant.PublishDate.HasValue && variant.PublishDate.Value.ToUniversalTime() > DateTime.UtcNow.AddSeconds(10)) {
                    var property = variant.Tabs.SelectMany(f => f.Properties).FirstOrDefault(property => property.Alias == PropertyAliases.IncludeInNextNewsletterAlias);
                    if (property != null) {
                        property.Value = "1";
                    }
                }
            }
        }
    }
}
