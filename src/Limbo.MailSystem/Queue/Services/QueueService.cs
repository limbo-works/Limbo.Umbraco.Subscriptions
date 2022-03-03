using System;
using System.Collections.Generic;
using System.Linq;

namespace Limbo.MailSystem.Queue.Services {
    public class QueueService : IQueueService {
        private bool _isItemRunning;
        private readonly object _lock = new();
        private readonly List<Action> _queue = new();

        public void RunNextAction() {
            Action? nextItem = null;
            lock (_lock) {
                if (_queue.Any()) {
                    nextItem = _queue.First();
                } else {
                    _isItemRunning = false;
                }
            }
            if (nextItem != null) {
                nextItem.Invoke();
            }
        }

        public void QueueUp(Action action) {
            if (!_isItemRunning) {
                lock (_lock) {
                    if (!_isItemRunning) {
                        _isItemRunning = true;
                        return;
                    }
                }
            }
            bool runAction = AddToQueue(action);
            if (runAction) {
                action.Invoke();
            }
        }

        public bool AddToQueue(Action action) {
            bool runAction = false;
            lock (_lock) {
                if (_isItemRunning) {
                    _queue.Add(action);
                } else {
                    runAction = true;
                }
            }

            return runAction;
        }
    }
}
