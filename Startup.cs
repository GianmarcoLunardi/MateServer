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
         //    string stringaDiConnessione = Configuration["ConnectionStrings:sqlite"];
        //     services.AddDbContext<Context>(opt => opt.UseSqlite(stringaDiConnessione));
            string stringaDiConnessione = Configuration["ConnectionStrings:sqlserver"];
            services.AddDbContext<Context>(opt => opt.UseSqlServer(stringaDiConnessione));
            services.AddControllers();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MakeSense", Version = "v1" });
            });

            services.AddTransient<IServiceAnnotation, ServiceAnnotation>();
            services.AddTransient<IServiceCategory, ServiceCategory>();
            services.AddTransient<IServiceCoordinate, ServiceCoordinate>();
            services.AddTransient<IServiceSegmentation, ServiceSegmentation>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MakeSense v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
