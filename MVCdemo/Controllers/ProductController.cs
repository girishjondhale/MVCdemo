using Microsoft.AspNetCore.Mvc;
using MVCdemo.Models;

namespace MVCdemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products= new List<Product>()
            {
                new Product { Id = 1, Name = "pen", Price = 20.01 },
                new Product { Id = 2, Name = "bat", Price = 2000.01 },
                new Product { Id = 3, Name = "mobile", Price = 15000.01 },
                new Product { Id = 4, Name = "laptop", Price = 20000.01 },
            };
            ViewData["list"] = products;
            return View();
        }
    }
}
