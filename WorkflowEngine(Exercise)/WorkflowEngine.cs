using System;
using System.Collections.Generic;

namespace WorkflowEngine_Exercise_
{
    public class WorkflowEngine : IWorkflow
    {
        private readonly List<IWorkflow> _workflow;

        public WorkflowEngine()
        {
            this._workflow = new List<IWorkflow>();
        }

        public void Execute()
        {
            foreach (var workflow in _workflow)
            {
                workflow.Execute();
            }
        }

        public void RegisterWorkflowActivities(IWorkflow iWorkflow)
        {
            this._workflow.Add(iWorkflow);
        }
    }
}