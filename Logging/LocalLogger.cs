using System;
using System.IO;

namespace TestBidone.Logging
{
    public class LocalLogger : ILogger
    {
        public void Info(string message)
        {
            File.AppendAllText($"data/log.txt", $"{message}{Environment.NewLine}");
        }
    }
}