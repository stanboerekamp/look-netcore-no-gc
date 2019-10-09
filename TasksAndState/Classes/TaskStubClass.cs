using System;
using System.Collections.Generic;
using System.Text;

namespace TasksAndState.Classes
{
    class TaskStubClass
    {
        private object _action;
        private object _state;

        public static TaskStubClass StartNew(Action action)
        {
            return new TaskStubClass(action);
        }

        public static TaskStubClass StartNew(Action<object> action, object state)
        {
            return new TaskStubClass(action, state);
        }

        public TaskStubClass(Action action)
        {
            _action = action;
            _state = null;
        }

        public TaskStubClass(Action<object> action, object state)
        {
            _action = action;
            _state = state;
        }
    }
}
