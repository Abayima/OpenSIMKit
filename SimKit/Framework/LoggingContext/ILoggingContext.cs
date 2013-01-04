using System;
using System.Collections.Generic;
using System.Text;

namespace SimKit.Framework.LoggingContext
{
    interface ILoggingContext
    {
        void Debug(string context, string message);

        void Info(string context, string message);
    }
}
