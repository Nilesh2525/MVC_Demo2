﻿using Microsoft.AspNetCore.Mvc;
using MVC_Demo2.Models;


namespace MVC_Demo2.Controllers
{

    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "pen", Price = 20.01 },
            new Product { Id = 2, Name = "abc", Price = 200.01 },
            new Product { Id = 3, Name = "qqq", Price = 2.01 },
            new Product { Id = 4, Name = "sss", Price = 202.01 }
        };
            ViewData["list"] = products;
            return View();
        }
    }
}