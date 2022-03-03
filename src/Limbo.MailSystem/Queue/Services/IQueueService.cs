using System;

namespace Limbo.MailSystem.Queue.Services {
    /// <summary>
    /// A service for managing queues of actions
    /// </summary>
    public interface IQueueService {

        /// <summary>
        /// Adds an action to the queue
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        /// <remarks><see cref="QueueUp(Action)"/> is the default method to use. This is a level deeper</remarks>
        bool AddToQueue(Action action);

        /// <summary>
        /// Tries to run the action if no action is running and will otherwise add it to the queue
        /// </summary>
        /// <param name="action"></param>
        void QueueUp(Action action);

        /// <summary>
        /// Runs the next action in the queue
        /// </summary>
        void RunNextAction();
    }
}