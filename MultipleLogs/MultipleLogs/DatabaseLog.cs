using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleLogs
{
    public class DatabaseLog : ILog
    {
        public void WriteLog(string message, string logType)
        {
            Console.WriteLine(logType + ": This is the Database Log: " + message);
            Console.WriteLine(logType + ": This is the Database Log: " + message);
            Console.WriteLine(logType + ": This is the Database Log: " + message);
            Console.WriteLine(logType + ": This is the Database Log: " + message);
            Console.WriteLine(logType + ": This is the Database Log: " + message);
            Console.WriteLine(logType + ": This is the Database Log: " + message);
            Console.WriteLine(logType + ": This is the Database Log: " + message);
            Console.WriteLine(logType + ": This is the Database Log: " + message);
            Console.WriteLine(logType + ": This is the Database Log: " + message);
            Console.WriteLine(logType + ": This is the Database Log: " + message);
        }
    }
}
