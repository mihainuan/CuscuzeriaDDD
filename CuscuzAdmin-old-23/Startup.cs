using AutoMapper;
using CuscuzeriaDDD.MVC.AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ninject;
using Ninject.Activation;
using Ninject.Infrastructure.Disposal;
using System;
using System.Threading;

namespace CuscuzAdmin
{
    public class Startup
    {
        //Added by Me (Dependency Injection - 23/03)
        private readonly AsyncLocal<Scope> scopeProvider = new AsyncLocal<Scope>();
        private IKernel Kernel { get; set; }
        private object Resolve(Type type) => Kernel.Get(type);
        private object RequestScope(IContext context) => scopeProvider.Value;
        private sealed class Scope : DisposableObject { }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            AutoMapperConfig.RegisterMappings();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddAutoMapper();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(5);
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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
