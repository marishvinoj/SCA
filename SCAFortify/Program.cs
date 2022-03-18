using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAFortify
{
    class Program
    {
        static void Main(string[] args)
        {
            object message = new ArgumentNullException();
            //Data Source = (local); Initial Catalog = master; Integrated Security = True
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "(local); Initial Catalog = master; Integrated Security = True";
            conn.Open();
            Info(message, new Exception(), args);
        }
        
        
        static void Info(object message, Exception ex, params object[] args)
        {
            string InstanceName = GetName("Report Instance Name [{0}] - ", "/textfile");
            if (message is string && args.Length > 0)
            {
                string msg = string.Format(InstanceName + (string)message, args);
            }
        }

        static string GetName(string formatString, string fileName)
        {
            Directory.CreateDirectory(fileName);
            return string.Format(formatString, "");
        }
    }
}
