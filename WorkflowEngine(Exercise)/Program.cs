using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine_Exercise_
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowEngine workflowEngine = new WorkflowEngine();
            workflowEngine.RegisterWorkflowActivities(new Upload());
            workflowEngine.RegisterWorkflowActivities(new VideoStatus());
            workflowEngine.RegisterWorkflowActivities(new SmsNotification());
            workflowEngine.Execute();
        }
    }
}
