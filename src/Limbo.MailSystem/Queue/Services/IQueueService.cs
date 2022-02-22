using System;

namespace Limbo.MailSystem.Queue.Services {
    public interface IQueueService {
        bool AddToQueue(Action action);
        void QueueUp(Action action);
        void RunNextAction();
    }
}