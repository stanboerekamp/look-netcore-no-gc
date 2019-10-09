using System;
using System.Collections.Generic;
using System.Text;

namespace TasksAndState.Structs
{
    struct TaskStubStruct
    {
        private object _action;
        private object _state;

        public static TaskStubStruct StartNew(Action action)
        {
            return new TaskStubStruct(action);
        }

        public static TaskStubStruct StartNew(Action<object> action, object state)
        {
            return new TaskStubStruct(action, state);
        }

        public TaskStubStruct(Action action)
        {
            _action = action;
            _state = null;
        }

        public TaskStubStruct(Action<object> action, object state)
        {
            _action = action;
            _state = state;
        }
    }
}
