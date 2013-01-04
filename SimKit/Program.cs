using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using SimKit.Framework;
using SimKit.Framework.SystemContext;
using SimKit.Framework.ConnectivityContext;
using SimKit.Framework.LoggingContext;

namespace SimKit
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            SetDependencies(args);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserInterface.MainApplicationWindow());
        }

        static void SetDependencies(string[] args)
        {
            if (args.Length == 0)
            {
                //TODO: Set up base dependencies
                return;
            }

            //Convert the args array to a list so that we can check whats in it
            var argsList = new List<string>(args);

            //Lovercase all the args
            argsList.ForEach(delegate(string s) { s = s.ToLower(); });

            //DEV case, use mock context
            if (argsList.Contains("-mock"))
            {
                Dependencies.SystemContext = new MockSystemContext();
                Dependencies.ConnectivityContext = new MockConnectivityContext();
                Dependencies.LoggingContext = new ConsoleLoggingContext();
            }
        }
    }
}
