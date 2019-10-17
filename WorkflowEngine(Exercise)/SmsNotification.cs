using System;

namespace WorkflowEngine_Exercise_
{
    public class SmsNotification : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Sms to the owner \"Video is processing\"");
        }
    }
}