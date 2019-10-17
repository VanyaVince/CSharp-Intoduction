using System;

namespace WorkflowEngine_Exercise_
{
    public class Upload : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Video is uploading");
        }
    }
}