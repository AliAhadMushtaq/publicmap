﻿using Abp.AspNetCore.Dependency;
using Abp.Dependency;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Maps.Web.Host.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        internal static IHostBuilder CreateHostBuilder(string[] args) =>
        Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>()
              
            .UseKestrel()
            .ConfigureKestrel(options =>
            {
                options.ListenAnyIP(8080);
            });
            
            })
            .UseCastleWindsor(IocManager.Instance.IocContainer);
    }
}
