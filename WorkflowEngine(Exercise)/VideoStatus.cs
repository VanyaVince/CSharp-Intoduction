using System;

namespace WorkflowEngine_Exercise_
{
    public class VideoStatus : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Status : \"Processing\"");
        }
    }
}