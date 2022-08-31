
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace net200
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args).ConfigureAppConfiguration((context, builder) =>
            {
                var env = context.HostingEnvironment;

                builder.AddJsonFile("appsettings.json");
            }).UseStartup<Startup>().Build().Run();
        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    .CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}
