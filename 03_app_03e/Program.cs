﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace app_03
{
    // dotnet add package Microsoft.Extensions.Hosting
    class Program
    {
        static void Main(string[] args)
        {
            var builder = Host.CreateDefaultBuilder();

            builder.ConfigureAppConfiguration((context, configuration) => {
                // context.Configuration
                var env = context.HostingEnvironment.EnvironmentName;
                
                configuration
                    .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
                    .AddJsonFile($"appsettings.{env}.json", optional:true, reloadOnChange:true);
            });
            builder.ConfigureServices((context, services) => {
                services.AddHostedService(_ => new AppService(
                    context.Configuration.GetValue("options:msg", "ok")
                ));
            });
            using var host = builder.Build();
            
            host.Run();
        }
    }
}
