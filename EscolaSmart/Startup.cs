using AutoMapper;
using EscolaSmart.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace EscolaSmart
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
            services.AddDbContext<DataContext>(context => context.UseSqlite(Configuration.GetConnectionString("Default")));

            services.AddScoped<IRepository, Repository>();

            services.AddControllers()
                    .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddVersionedApiExplorer
                        (options =>
                            {
                                options.GroupNameFormat = "'v'VVV";
                                options.SubstituteApiVersionInUrl = true;
                            }
                        )
                    .AddApiVersioning
                        (options =>
                            {
                                options.DefaultApiVersion = new ApiVersion(1, 0);
                                options.AssumeDefaultVersionWhenUnspecified = true;
                                options.ReportApiVersions = true;
                            }
                        );

            #pragma warning disable ASP0000 // Do not call 'IServiceCollection.BuildServiceProvider' in 'ConfigureServices'
            var apiProviderDescription = services.BuildServiceProvider().GetService<IApiVersionDescriptionProvider>();
            #pragma warning restore ASP0000 // Do not call 'IServiceCollection.BuildServiceProvider' in 'ConfigureServices'

            services.AddSwaggerGen(options =>

                { 
                    foreach(var description in apiProviderDescription.ApiVersionDescriptions)
                    {
                        options.SwaggerDoc(description.GroupName, new Microsoft.OpenApi.Models.OpenApiInfo()
                        {
                            Title = "EscolaSmartAPI",
                            Version = description.ApiVersion.ToString(),
                            TermsOfService = new Uri("https://google.com"),
                            Description = "A descrição da WebAPI da EscolaSmart",
                            License = new Microsoft.OpenApi.Models.OpenApiLicense
                            {
                                Name = "EscolaSmart Lincese",
                                Url = new Uri("https://google.com")
                            },
                            Contact = new Microsoft.OpenApi.Models.OpenApiContact
                            {
                                Name = "Fernando Santana",
                                Email = "fernandodasilvasantana@hotmail.com",
                                Url = new Uri("https://www.linkedin.com/in/fernandsantana/")
                            }

                        });
                    }

                    var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

                    options.IncludeXmlComments(xmlCommentsFullPath);
                });
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
                              IWebHostEnvironment env,
                              IApiVersionDescriptionProvider apiProviderDescription)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseSwagger().UseSwaggerUI(options =>
            {
                foreach (var description in apiProviderDescription.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
                }
                
                options.RoutePrefix = ""; });

            // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
