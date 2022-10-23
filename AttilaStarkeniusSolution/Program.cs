using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttilaStarkeniusSolution
{
    public class Program
    {
        /*22.10.2022. The git repository for httpspandacom stopped
        working so I created https://github.com/AttilaStarkenius/AttilaStarkeniusSolution
        instead, and add the existing GenericsDemo project to it,
        set it as startup project and it's working.*/
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
