using Cuscuzeria.Infra.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cuscuzeria.API
{
    public class Startup
    {
        //References the Configuration (ConnectionString)
        IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("config.json");
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var conn = Configuration.GetConnectionString("CuscuzeriaDB");

            services.AddDbContext<CuscuzeriaContext>(option =>
                option.UseLazyLoadingProxies()
                .UseMySql(conn, m => m.MigrationsAssembly("Cuscuzeria.Infra.Data")));

            services.AddMvcCore();
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
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
