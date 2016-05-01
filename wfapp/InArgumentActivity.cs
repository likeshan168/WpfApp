using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace wfapp
{

    public sealed class InArgumentActivity : CodeActivity
    {
        // 定义一个字符串类型的活动输入参数
        public InArgument<string> MyIn { get; set; }

        // 如果活动返回值，则从 CodeActivity<TResult>
        // 并从 Execute 方法返回该值。
        protected override void Execute(CodeActivityContext context)
        {
            // 获取 Text 输入参数的运行时值
            //string text = context.GetValue(this.Text);
            string s1 = context.GetValue(MyIn);
            string s2 = MyIn.Get(context);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine("asdfasdfa");
        }
    }
}
