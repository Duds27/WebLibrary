using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using DDD.API.App_Start;
using DDD.Infra.Persistence;
using DDD.IoC.Unity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using Swashbuckle.AspNetCore.Swagger;
using Unity;
using DDD.API.App_Start;
using DDD.Infra.Transactions;

namespace DDD.API
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
            services.AddDbContext<LibraryContext>(options => 
                options.UseSqlServer(@"Server=DESKTOP-TGA2QF7;Database=LivrariaHbsis;Trusted_Connection=True;"));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // // Register the Swagger generator, defining 1 or more Swagger documents
            // services.AddSwaggerGen(c =>
            // {
            //     c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            // });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

             // Enable middleware to serve generated Swagger as a JSON endpoint.
            //app.UseSwagger();

            //HttpConfiguration config = new HttpConfiguration();

            // Swagger
            //SwaggerConfig.Register(config);

            // Configure Dependency Injection
            // var container = new UnityContainer();
            // DependencyResolver.Resolve(container);
            // config.DependencyResolver = new UnityResolver(container);


            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            // app.UseSwaggerUI(c =>
            // {
            //     c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            // });
            
            app.UseHttpsRedirection();
            app.UseMvc();
        }
       
    }
}
