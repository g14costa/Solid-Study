using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace MultipleLogs
{
    public class LogManager
    {
        public List<ILog> _logs { get; set; }
        private LogManager()
        {
            _logs = new List<ILog>();
            _logs.Add(new EmailLog());
            _logs.Add(new ConsoleLog());
            _logs.Add(new DatabaseLog());

        }

        private static Lazy<LogManager> _logManagerSingleton = new Lazy<LogManager>(() => new LogManager());

        public static LogManager LogManagerInstance
        {
            get { return _logManagerSingleton.Value; }
        }

        public readonly IDictionary<LogType, Func<IList<ILog>>> logDictionary = new Dictionary<LogType, Func<IList<ILog>>>() {
            {LogType.Error, () => GetErrorLog()}
        };

        public void WriteLog(string message, LogType logType)
        {
            var logs = logDictionary[logType]().ToList();

            logs.ForEach(i => i.WriteLog(message, logType.ToString()));
        }

        private static IList<ILog> GetErrorLog()
        {
            return new List<ILog>()
            {
                new ConsoleLog()
            };
        }
    }
}
