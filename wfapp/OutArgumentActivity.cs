using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace wfapp
{

    public sealed class OutArgumentActivity : CodeActivity
    {
        // 定义一个字符串类型的活动输入参数
        public OutArgument<string> myOut { get; set; }

        // 如果活动返回值，则从 CodeActivity<TResult>
        // 并从 Execute 方法返回该值。
        protected override void Execute(CodeActivityContext context)
        {
            // 获取 Text 输入参数的运行时值
            string s1 = myOut.Get(context);
            myOut.Set(context, "sherman:" + s1);
            string s2 = context.GetValue(myOut);
            context.SetValue(myOut, "andy:" + s2);
        }
    }
}
