using System;

namespace MultipleLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1, b = 0, error = 0;
                error = a / b;
            }
            catch (Exception e)
            {
                new LogManager().WriteLog(e.Message, LogType.Error);
            }
        }
    }
}
