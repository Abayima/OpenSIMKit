using System;
using System.Collections.Generic;
using System.Text;
using SimKit.Framework.ConnectivityContext;
using SimKit.Framework.SystemContext;
using SimKit.Framework.LoggingContext;

namespace SimKit.Framework
{
    internal class Dependencies
    {
        public static IConnectivityContext ConnectivityContext { get; set; }

        public static ISystemContext SystemContext { get; set; }

        public static ILoggingContext LoggingContext { get; set; }
    }
}
