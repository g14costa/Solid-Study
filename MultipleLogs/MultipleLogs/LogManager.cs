using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleLogs
{
    public class LogManager
    {
        public void WriteLog(string message, LogType logType)
        {
            List<ILog> logs = new List<ILog>();
            logs.Add(new EmailLog());
            logs.Add(new ConsoleLog());
            logs.Add(new DatabaseLog());

            logs.ForEach(i => i.WriteLog(message, logType.ToString()));
        }
    }
}
