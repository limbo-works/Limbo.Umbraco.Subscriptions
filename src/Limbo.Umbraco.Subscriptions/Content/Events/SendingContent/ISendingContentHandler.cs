using Umbraco.Cms.Core.Notifications;

namespace Limbo.Umbraco.Subscriptions.Content.Events.SendingContent {
    /// <summary>
    /// A handler that is activaed when content is being sent to the backoffice aka. being opend by an editor
    /// </summary>
    /// <remarks>
    /// This can be used to set default values
    /// </remarks>
    public interface ISendingContentHandler {

        /// <summary>
        /// Called on notification
        /// </summary>
        /// <param name="notification"></param>
        void Handle(SendingContentNotification notification);
    }
}