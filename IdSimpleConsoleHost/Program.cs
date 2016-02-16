using System;
using System.Collections.Generic;
using IdentityServer3.Core.Logging;
using Microsoft.Owin.Hosting;
using Serilog;

namespace IdSimpleConsoleHost
{
    class Program
    {
        private static void Main(string[] args)
        {
            // logging
            Log.Logger = new LoggerConfiguration()
                .WriteTo
                .LiterateConsole(outputTemplate: "{Timestamp:HH:MM} [{Level}] ({Name:l}){NewLine} {Message}{NewLine}{Exception}")
                .CreateLogger();

            // hosting identityserver
            using (WebApp.Start<Startup>("http://localhost:5000"))
            {
                Console.WriteLine("server running at localhost port 5000... Press enter to stop.");
                Console.ReadLine();
            }

        }
    }
}
