using System;
using System.IO;

namespace AuthenticationService
{
    public class Logger : ILogger
    {
        private readonly string logsPath = "logs";

        public Logger()
        {
            if (!Directory.Exists(logsPath))
            {
                Directory.CreateDirectory(logsPath);
            }
        }

        public void WriteEvent(string eventMessage)
        {
            File.AppendAllText(Path.Combine(logsPath, "events.txt"), eventMessage + Environment.NewLine);
            Console.WriteLine(eventMessage);
        }

        public void WriteError(string errorMessage)
        {
            File.AppendAllText(Path.Combine(logsPath, "errors.txt"), errorMessage + Environment.NewLine);
            Console.WriteLine(errorMessage);
        }
    }
}
