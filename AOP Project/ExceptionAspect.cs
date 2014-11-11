using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace AOP_Project
{
    [Serializable]
    public class ExceptionAspect : OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine("Exception : " + args.Exception.Message + " at " + DateTime.Now);
            args.FlowBehavior = FlowBehavior.Continue;

            base.OnException(args);
        }
    }
}
