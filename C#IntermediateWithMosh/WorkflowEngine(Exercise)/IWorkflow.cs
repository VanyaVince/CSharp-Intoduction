using System.Collections.Generic;

namespace WorkflowEngine_Exercise_
{
    public interface IWorkflow
    {
        void Add(ITasks iTask);
        void Remove(ITasks itTask);
        IEnumerable<ITasks> GetTasks();
    }
}