using Microsoft.AspNetCore.Mvc;
using MVCdemo.Models;
using System.Diagnostics;

namespace MVCdemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["message"] = "welcome to mvc demo";
            List<string> list = new List<string>()
            {
                "red",
                "green",
                "yellow",
                "blue",
                "pink",

            };
            ViewData["colours"]=list;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return View();
        }
        public IActionResult Contactus()
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