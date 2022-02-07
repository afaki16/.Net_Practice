using System;

namespace Arayuzler
{
    public class FileLogger : ILogger
    {
        public void writeLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dosyaya log yazar.");
        }
    }
}