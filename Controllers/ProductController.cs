using DatabaseAppMockarooData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DatabaseAppMockarooData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<ProductModel> productsList = new List<ProductModel>();

            productsList.Add(new ProductModel { Id = 1, Name = "Mouse Pad", Price = 5.99m, Description = "A square piece of plastic to make mousing easier" });
            productsList.Add(new ProductModel { Id = 2, Name = "Web Cam", Price = 45.50m, Description = "Enables you attend more Zoom meetings" });
            productsList.Add(new ProductModel { Id = 3, Name = "4 TB USB hard drive", Price = 130.00m, Description = "Backup all of your work. You won't regret it." });
            productsList.Add(new ProductModel { Id = 4, Name = "Wireless Mouse", Price = 15.99m, Description = "Notebook mice don't work very well, do they?" });

            return View(productsList);
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
