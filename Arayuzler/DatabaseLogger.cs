using System;

namespace Arayuzler
{
    public class DatabaseLogger : ILogger
    {
        public void writeLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Veritabanına log yazar.");
        }
    }
}