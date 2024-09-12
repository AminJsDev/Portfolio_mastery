using Microsoft.AspNetCore.Mvc;
using Portfolio_MVC.Models;
using System.Diagnostics;

namespace Portfolio_MVC.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
   
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactMe()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
