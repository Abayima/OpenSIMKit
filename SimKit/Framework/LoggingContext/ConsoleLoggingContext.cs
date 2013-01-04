using System;
using System.Collections.Generic;
using System.Text;

namespace SimKit.Framework.LoggingContext
{
    class ConsoleLoggingContext : ILoggingContext
    {
        public void Debug(string context, string message)
        {
            Console.WriteLine("DEBUG: " + context + ": " + message);
        }

        public void Info(string context, string message)
        {
            Console.WriteLine("INFO: " + context + ": " + message);
        }
    }
}
