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
            var workflow = new Workflow();
            workflow.Add(new Upload());
            workflow.Add(new VideoStatus());
            workflow.Add(new SmsNotification());

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}
