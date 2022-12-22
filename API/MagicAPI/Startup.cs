using MagicAPI.Application;
using MagicAPI.Application.Interface;
using MagicAPI.Context;
using MagicAPI.IntegrationService;
using MagicAPI.IntegrationService.Interface;
using MagicAPI.Repository;
using MagicAPI.Repository.Interface;
using MagicAPI.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MtgApiManager.Lib.Service;
using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
using MagicAPI.Service.Interface;
using MagicAPI.Models.Interface;
using MagicAPI.Models;

namespace MagicAPI
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
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<ApplicationDbContext>();

            services.AddScoped<IMtgServiceProvider, MtgServiceProvider>();

            services.AddScoped<IMTGSDkIntegrationService, MTGSDkIntegrationService>();
            services.AddScoped<ICardMarketAPIIntegrationService, CardMarketAPIIntegrationService>();


            services.AddScoped<ICardApplication, CardApplication>();
            services.AddScoped<Service.Interface.ICardService, CardService>();
            services.AddScoped<IDeckCardService, DeckCardService>();
            services.AddScoped<ICardRepository, CardRepository>();

            services.AddScoped<IDeckApplication, DeckApplication>();
            services.AddScoped<Service.Interface.IDeckService, DeckService>();
            services.AddScoped<IDeckRepository, DeckRepository>();
            services.AddScoped<IDeckCardRepository, DeckCardRepository>();
            services.AddMemoryCache();

            services.AddCors();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddControllers().AddJsonOptions(x =>
                 x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            //string json = JsonConvert.SerializeObject( 
            //{
            //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            //});

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MagicAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MagicAPI v1"));
            }

            var allowedOrigins = "http://localhost:4200";
            app.UseCors(x => x
                .WithOrigins(allowedOrigins)
                .AllowAnyMethod()
                .AllowAnyHeader());

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
