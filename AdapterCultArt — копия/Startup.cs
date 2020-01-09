using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using AdapterLibrary;
using AdapterMonListOfTourizm.ServiceContract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using XRoadLib.Extensions.AspNetCore;

namespace AdapterMonListOfTourizm
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext <aismkitdbContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IGetLisencesSoap, GetListOfTourizmDetailsWebServices>();

            services.AddScoped<GetListOfTourizmServiceManager>();
            services.AddScoped<GetLibServiceManager>();
            
            services.AddXRoadLib();

            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            // If using IIS:
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }            
            //else
            //{
            //    app.UseExceptionHandler("/error");
            //}
            // app.UseSoapEndpoint(path: "/PingService.svc", binding: new BasicHttpBinding());
            app.UseXRoadLib(routeBuilder =>
            {
                routeBuilder.MapWsdl<GetListOfTourizmServiceManager>("/wsdl");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfTourizm");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfCinematografy");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfMedias");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfTourizmIndicators");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfMonuments");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfRntObject");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfEvtObj");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfCinemaCert");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfCinemaDocs");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfCinemaOrg");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfEduOrg");
                //routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfLibOrg");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfProtMonum");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfStateAward");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfTZY");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfRntRoomObject");
                routeBuilder.MapWebService<GetListOfTourizmServiceManager>("/GetListOfObjCult");

                routeBuilder.MapWsdl<GetLibServiceManager>("/GetListOfLibOrg/wsdl");
                routeBuilder.MapWebService<GetLibServiceManager>("/GetListOfLibOrg");
                

                //routeBuilder.MapWsdl<GetListOfTourizmServiceManager>("GetLisences?wsdl");
                //routeBuilder.MapWebService<GetListOfTourizmServiceManager>("Getlisences");
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
