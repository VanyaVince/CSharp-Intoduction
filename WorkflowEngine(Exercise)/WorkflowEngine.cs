using System;
using System.Collections.Generic;

namespace WorkflowEngine_Exercise_
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow iWorkflow)
        {
            foreach (var workflow in iWorkflow.GetTasks())
            {
                workflow.Execute();
            }
        }
    }
}