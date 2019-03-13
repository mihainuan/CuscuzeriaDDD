using CuscuzeriaDDD.MVC.AutoMapper;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CuscuzeriaDDD.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            AutoMapperConfig.RegisterMappings();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
