using System.Collections.Generic;

namespace WorkflowEngine_Exercise_
{
    public class Workflow : IWorkflow
    {
        private readonly List<ITasks> _tasks;

        public Workflow()
        {
            this._tasks = new List<ITasks>();
        }

        public void Add(ITasks iTask)
        {
            this._tasks.Add(iTask);
        }

        public void Remove(ITasks itTask)
        {
            this._tasks.Remove(itTask);
        }

        public IEnumerable<ITasks> GetTasks()
        {
            return this._tasks;
        }
    }
}