using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection; //added DI 
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using LegacyView.Data; 
using LegacyView.Models;
using System;

namespace LegacyView
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //added code to reference SeedData
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
