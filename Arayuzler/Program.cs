using System;

namespace Arayuzler
{
   
   class Program
    {
        static void Main(string[] args)
        {
            FileLogger file = new FileLogger();;
            file.writeLog();

            DatabaseLogger database = new DatabaseLogger();
            database.writeLog();

            SmsLogger sms = new();
            sms.writeLog();

            LogManager logger = new LogManager(new FileLogger());
            logger.writeLog();
        }
    }
}
