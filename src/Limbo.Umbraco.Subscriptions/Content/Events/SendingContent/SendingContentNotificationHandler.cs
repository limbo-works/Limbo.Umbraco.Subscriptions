using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;

namespace Limbo.Umbraco.Subscriptions.Content.Events.SendingContent {
    internal class SendingContentNotificationHandler : INotificationHandler<SendingContentNotification> {
        private readonly ISendingContentHandler _sendingContentHandler;

        public SendingContentNotificationHandler(ISendingContentHandler sendingContentHandler) {
            _sendingContentHandler = sendingContentHandler;
        }

        public void Handle(SendingContentNotification notification) {
            _sendingContentHandler.Handle(notification);
        }

    }
}
