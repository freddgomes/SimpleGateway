using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SimpleGateway.Domain.ApiClient;
using SimpleGateway.Domain.Configuration;
using SimpleGateway.Domain.Repository;
using SimpleGateway.Domain.Services;
using SimpleGateway.Infrastructure.ApiClient;
using SimpleGateway.Infrastructure.Repository;
using SimpleGateway.Service.Services;

namespace SimpleGateway.Api
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
            services.AddTransient<ISalesService, SalesService>();
            services.AddTransient<ITransactionsService, TransactionsService>();
            services.AddTransient<ITransactionRepository, TransactionRepository>();
            services.AddTransient<ICieloClient, CieloClient>();
            services.AddSingleton<IAppSettings, AppSettings>();

            services.AddAutoMapper();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            });
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

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
