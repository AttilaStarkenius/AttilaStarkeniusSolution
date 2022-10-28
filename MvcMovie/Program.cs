using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie
{
    public class Program
    {
        /*25.10.2022. I just move on to next tutorial: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio
            like this: "Start Visual Studio and select Create a new project.
In the Create a new project dialog, select ASP.NET Core Web App(Model-View-Controller) > Next.
In the Configure your new project dialog, enter MvcMovie for Project name.It's important to name the project MvcMovie. Capitalization needs to match each namespace when code is copied.
Select Next.
In the Additional information dialog, select.NET 6.0 (Long-term support).
Select Create."
            Actually I choose.NET 3.1 because I only have Visual Studio 2019
        then I go to next part https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-6.0&tabs=visual-studio
        like this: "Add a controller
Visual Studio
Visual Studio Code
Visual Studio for Mac
In Solution Explorer, right-click Controllers > Add > Controller."*/
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /*28.10.2022. I do tutorial https://learn.microsoft.com/en-us/shows/csharp-fundamentals-for-absolute-beginners/understanding-your-first-c-program
         * so I create a C# console application "HelloWorld"*/
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
