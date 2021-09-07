using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasualEmployee.API.Data;
using CasualEmployee.API.Data.MockRepos;
using CasualEmployee.API.Data.Repos.Casual_Emp;
using CasualEmployee.API.Data.Repos.Persons;
using CasualEmployee.API.Data.Repos.Roles;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace CasualEmployee.API
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CasualEmployee.API", Version = "v1" });
            });

            //Register AutoMapper 
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //Register Repo for DI
            services.AddScoped<IRolesRepo, RolesRepo>();
            services.AddScoped<IPersonRepo, P_MockRepo>();
            services.AddScoped<ICasualEmpRepo, CEM_MockRepo>();
            //Register connection string
            services.AddDbContext<CEContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("CEConnectionString")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CasualEmployee.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
