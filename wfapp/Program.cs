using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;

namespace wfapp
{

    class Program
    {
        static void Main(string[] args)
        {
            //Activity workflow1 = new SayHello();
            //Activity workflow1 = new SayHelloInCode();

            //WorkflowInvoker.Invoke(workflow1);

            //WorkflowApplication instance = new WorkflowApplication(new SayHello());
            //instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            //Console.WriteLine(instance.Id);
            //instance.Run();
            //Console.Read();
            //startValueInWorkflow();
            //InArgumentWorkflow();
            //startValueOutWorkflow();
            OutArgumentWorkflow();
        }

        static void workflowCompleted(WorkflowApplicationCompletedEventArgs e)
        {
            Console.WriteLine("状态：{0}", e.CompletionState.ToString());
            Console.WriteLine("实例编号：{0}", e.InstanceId);
        }

        static void startValueInWorkflow()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            
            dic.Add("v1", 123.456);
            dic.Add("v2", 456.789);
            WorkflowApplication instance = new WorkflowApplication(new SayHello(),dic);
            instance.Run();
            Console.Read();

        }

        static void InArgumentWorkflow()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("myValue","how are you?");
            WorkflowApplication instance = new WorkflowApplication(new InArgumentWorkflow(),dic);
            instance.Run();
            Console.Read();
        }


        static void startValueOutWorkflow()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("v1", 123.456);
            dic.Add("v2", 456.789);
            WorkflowApplication instance = new WorkflowApplication(new StartValueOWorkflow(),dic);
            instance.Completed = completed;
            instance.Run();
            Console.Read();
        }
        static void completed(WorkflowApplicationCompletedEventArgs e)
        {
            Console.WriteLine(e.Outputs["v3"].ToString());
        }

        static void OutArgumentWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new OutArgumentCodeWorkflow());
            instance.Run();
            Console.Read();
        }
    }
}
