using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAFortify
{
    class Program
    {
        static void Main(string[] args)
        {
            object message = "test";
            Info(message, new Exception(), args);
        }
        
        
        static void Info(object message, Exception ex, params object[] args)
        {
            string InstanceName = "Report Instance Name [{0}] - ";
            if (message is string && args.Length > 0)
            {
                string msg = string.Format(InstanceName + (string)message, args);
            }
        }
    }
}
