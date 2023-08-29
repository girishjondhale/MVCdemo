using Microsoft.AspNetCore.Mvc;
using MVCdemo.Models;

namespace MVCdemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> s = new List<Student>()
            {
                new Student {Name = "Girish",roll = 11,Percentage=80.0 },
                new Student {Name = "Sagar", roll = 12 ,Percentage=90.0},
                new Student {Name = "Nilesh", roll = 13,Percentage=80.0 },
                new Student {Name = "pankaj", roll = 14,Percentage=84.0 },
                new Student {Name = "pratik", roll = 15,Percentage=85.0 },
            };
            ViewData["list"] = s;
            return View();
        }
    }
}
