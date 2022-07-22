using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //action method in mvc
        public IActionResult Index()
        {
            ViewData["message"] = "This is my mvc application";
            string[] names = { "Ketaki", "Utkarsh", "Rajesh", "Om" };

            ViewData["namelist"]=names;

            List<Employee> emplist = new List<Employee>()
            {
                new Employee { Id=1,Name="Ketaki",Department="IT", Salary=25000},
                new Employee { Id = 2, Name = "Utkarsh", Department = "Admin", Salary = 27000 },
                new Employee { Id = 3, Name = "Rajesh", Department = "IT", Salary = 35000 },
                new Employee { Id = 4, Name = "Om", Department = "BA", Salary = 25000 }

            };
            ViewData["emplist"] = emplist;
            return View();
        }

        public IActionResult Privacy()
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
