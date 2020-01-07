using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config) // in asp.net  external framework dependency inj used but here integral part
            //dep inj allows to create systems loosely coupled extensible and easily testible
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IEmployeeRepository,MockEmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) //, ILogger<Startup> logger
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // an exception, in case of;
            }
            
            app.UseStaticFiles();
            app.UseMvc(routes => 
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}"); //conventional routing
            });

        }
    }
}










//app.UseMvcWithDefaultRoute();
//app.UseMvc(); //for attribute routing, also check home controller's routes
/*app.Run(async (context) => //this middleware responds to every request; terminal middleware capable of running solely
{
    //throw new Exception("Some problem handling the request");
    await context.Response.WriteAsync("Hello World!");// creates a Response hence reverses the pipeline 
    //logger.LogInformation("MW3: Request Handled and respinse generated");
});*/

// IIS is InProcess hosting rn
// inporcess is better in performance standpoint
// since app is being run form VS therefore web host is bydefault IISExpress to run and host app using iisexpress.exe
// only one web server 
/// lightwight version of IIS only used in dev not in prod
// if run from cli it will show dotnet as web host


// allow the next middleware to run; allow it in a perimeter; use App.Use() :: next takes func a generic perimeter
//if you wanna lof some stuff to output log then use ILogger interface which does the work

/*
            app.Use(async (context , next) => 
            {
                logger.LogInformation("MW1: Incoming request");
                await next();
                logger.LogInformation("MW1: Outgoing Response"); 

            });
            app.Use(async (context, next) => 
            {
                logger.LogInformation("MW2: Incoming request");
                await next();
                logger.LogInformation("MW2: Outgoing Response");

            });
*/
/*
            DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();
            defaultFilesOptions.DefaultFileNames.Add("foo.html");            
            app.UseDefaultFiles(defaultFilesOptions); // can have default.html or index.html ; to be served before the terminal middleware
            
            app.UseStaticFiles();
 
     */
/*
 * 
            FileServerOptions fileServerOptions = new FileServerOptions();
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
 */

// use.fileserver finds two of its predecessor's options, if none is avaialable then it will move to the next middleware i.e the app.ru
//use.devexcpage should be plugged in as early as possible in the pipeline works like a beacon of light


/*
 DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions
                {
                    SourceCodeLineCount = 20
                };
*/
