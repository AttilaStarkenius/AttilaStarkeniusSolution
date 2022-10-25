using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        /*25.10.2022. I commit and push to git changes
         with message "25.10.2022. Doing tutorial https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-6.0&tabs=visual-studio"

        // 
        // GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}

        /*25.10.2022. I go to next page in tutorial
        https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-6.0&tabs=visual-studio
        I commit and push to Git Changes with message "25.10.2022. Doing Classes tutorial
        and beginning MvcMovie tutorial"*/


        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}


        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}
    }
}