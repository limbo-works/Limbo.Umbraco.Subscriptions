using Umbraco.Cms.Core.Notifications;

namespace Limbo.Umbraco.Subscriptions.Content.Events.SendingContent {
    public interface ISendingContentHandler {
        void Handle(SendingContentNotification notification);
    }
}