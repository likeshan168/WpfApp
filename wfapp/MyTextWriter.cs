using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfapp
{
    public class MyTextWriter : TextWriter
    {
        public override Encoding Encoding
        {
            get
            {
                return Encoding.UTF8;
            }
        }
        public override void WriteLine(string value)
        {
            Console.WriteLine("sherman:" + value);
        }

    }
}
