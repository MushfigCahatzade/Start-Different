using ASPnetT1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASPnetT1.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "BMW", Description="d1",Image="p1.jpg",Price=50},
                new Product { Id = 2, Name = "Audi", Description="d1",Image="p2.jpg",Price=100},
                new Product { Id = 3, Name = "Kia", Description="d1",Image="p3.jpg",Price=150}
            };
            return View(products);
        }
    }
}
