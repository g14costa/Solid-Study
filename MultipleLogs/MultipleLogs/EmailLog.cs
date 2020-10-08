using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleLogs
{
    public class EmailLog : ILog
    {
        public void WriteLog(string message, string logType)
        {
            Console.WriteLine(logType + ": This is the Email Log: " + message);
        }
    }
}
