using System;
using System.IO;
using System.Reflection;
using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace CleanArchitecture.Api
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
            services.AddApplication()
                .AddInfrastructure(Configuration);

            services.AddSwaggerGen(setupAction =>
            {
                setupAction.SwaggerDoc("CleanArchitecture", new OpenApiInfo
                {
                    Title = "Clean Architecture",
                    License = new OpenApiLicense
                    {
                        Name = "Anup Hosur",
                        Url = new Uri("https://dotnetintellect.com")
                    },
                    Version = "1.0",
                    Contact =new OpenApiContact
                    {
                        Email = "anup1252000@dotnetintellect.com"
                    }
                });

                var fileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentFullPath = Path.Combine(AppContext.BaseDirectory, fileName);
                setupAction.IncludeXmlComments(xmlCommentFullPath, true);
            }); 

            //services.AddHealthChecks()
            //     .AddDbContextCheck<ApplicationDbContext>();
            services.AddControllers();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint("/Swagger/CleanArchitecture/swagger.json", "Clean Architecture");
                setupAction.RoutePrefix = "";

            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
