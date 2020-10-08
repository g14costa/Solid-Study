using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleLogs
{
    public class ConsoleLog : ILog
    {
        public void WriteLog(string message, string logType)
        {
            Console.WriteLine(logType + ": This is the Console Log: " + message);
        }
    }
}
