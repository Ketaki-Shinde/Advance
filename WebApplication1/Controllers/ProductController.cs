using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace MVCDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> plist = new List<Product>()
            {
                new Product{ Id=101, Name = "HP Laptop", Price=44000 },
                new Product{ Id=102, Name = "Dell Laptop", Price=54000 },
                new Product{ Id=103, Name = "Lenovo Laptop", Price=46000 }
            };

            ViewBag.ProductList = plist;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            ViewBag.Id = form["pid"];
            ViewBag.Name = form["pname"];
            ViewBag.Price = form["price"];

            return View();
        }
    }
}
