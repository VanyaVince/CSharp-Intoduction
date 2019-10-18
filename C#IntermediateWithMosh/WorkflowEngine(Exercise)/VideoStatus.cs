using System;

namespace WorkflowEngine_Exercise_
{
    public class VideoStatus : ITasks
    {
        public void Execute()
        {
            Console.WriteLine("Status : \"Processing\"");
        }
    }
}