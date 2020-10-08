using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleLogs
{
    public interface ILog
    {
        void WriteLog(string message, string logType);
    }
}
