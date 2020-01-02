using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response
                .WriteAsync(_config["MyKey"]);
            });
        }
    }
}

// IIS is InProcess hosting rn
// inporcess is better in performance standpoint
// since app is being run form VS therefore web host is bydefault IISExpress to run and host app using iisexpress.exe
// only one web server 
/// lightwight version of IIS only used in dev not in prod
// if run from cli it will show dotnet as web host


