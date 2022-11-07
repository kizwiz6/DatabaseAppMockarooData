using Bogus;
using DatabaseAppMockarooData.Models;
using DatabaseAppMockarooData.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DatabaseAppMockarooData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // Instantiate a new copy of ProductsDAO
            ProductsDAO products = new ProductsDAO();

            return View(products.GetAllProducts());
        }

        public IActionResult Message()
        {
            return View("message");
        }

        public IActionResult Welcome(string name, int secretNumber = 13)
        {
            ViewBag.Name = name;
            ViewBag.Secret = secretNumber;
            return View();
        }
    }
}
