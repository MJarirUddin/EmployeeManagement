using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement
{
    public class Program
    {
        public static void Main(string[] args) //kicks off as a console app and then // dotnet runtime looks for main
        {
            CreateWebHostBuilder(args).Build().Run(); //converts to a dotnet web app
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args) 
                .UseStartup<Startup>();
    }
}
// activities of CreateDefaultBuilder;

// sets up web server  : useIIS() 
// loads the host  : inside the IIS worker process e.g w3wp.exe or iis.exe 
// inprocess is good at delivering request
// and app config
// config log
