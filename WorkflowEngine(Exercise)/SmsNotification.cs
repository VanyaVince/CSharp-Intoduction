using System;

namespace WorkflowEngine_Exercise_
{
    public class SmsNotification : ITasks
    {
        public void Execute()
        {
            Console.WriteLine("Sms to the owner \"Video is processing\"");
        }
    }
}