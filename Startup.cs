using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using MakeSense.Models;
using Microsoft.Data.Sqlite;
using MakeSense.Services.Interface;
using MakeSense.Services;
using AutoMapper;
using System.Reflection;
using Microsoft.AspNetCore.Cors;


namespace MakeSense
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //    covenzione su j aosn));



           
            string stringaDiConnessione = Configuration["ConnectionStrings:sqlserver"];
            services.AddDbContext<Context>(opt => opt.UseSqlServer(stringaDiConnessione));
            services.AddControllers();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MakeSense", Version = "v1" });
            });


            //DI Dei Servizi....

            services.AddTransient<IServiceAnnotation, ServiceAnnotation>();
            services.AddTransient<IServiceCategory, ServiceCategory>();
            services.AddTransient<IServiceCoordinate, ServiceCoordinate>();
            services.AddTransient<IServiceCoordinateB, ServiceCoordinateB>();
            services.AddTransient<IServiceSegmentation, ServiceSegmentation>();
            services.AddTransient<IServiceInfo, ServiceInfo>();
            services.AddTransient<IServiceUtente, ServiceUser>();

            // configurazione di automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddTransient<IServiceImage, ServiceImage>();
            // aggiungere il servizio cors
            services.AddCors(options =>
                options.AddPolicy(name: "AngularPolicy",
                    cfg => {
                    cfg.AllowAnyHeader();
                    cfg.AllowAnyMethod();
                    cfg.WithOrigins(Configuration["AllowedCORS"]);
                }));
            //services.AddCors();
            // configurazione di automapper
            services.AddAutoMapper(System.AppDomain.CurrentDomain.GetAssemblies());


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
              app.UseDeveloperExceptionPage();
              app.UseSwagger();
              app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mate2Tag v1"));
            }

            //app.UseCors(c => c.AllowAnyOrigin());
            app.UseCors("AngularPolicy");
            

            // aggiuto da manuale
            app.UseStaticFiles();


            app.UseAuthorization();


            //https://www.youtube.com/watch?v=MOVOHHFSCRI

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllers();


                endpoints.MapControllerRoute(
                name: "default",
                 pattern: " { controller}/{action}/{id?}/{id2?}");


               
            });
        }
    }
}


//