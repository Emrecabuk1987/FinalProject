using System;

namespace Business.demo
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Db Loglandı");
        }
    }
}



