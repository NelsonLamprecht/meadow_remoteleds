using System;

using Meadow;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;

namespace meadow_remoteleds
{
    internal class Program
    {
        public static IConfigurationRoot Configuration { get; set; }

        static IApp app;

        public static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "--exitOnDebug") return;

            //var builder = new ConfigurationBuilder();

            //// tell the builder to look for the appsettings.json file
            //builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            //builder.AddUserSecrets<Program>();

            //Configuration = builder.Build();

            // instantiate and run new meadow app
            app = new MeadowApp();

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
