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

        /// <summary>
        /// New method that will accept a string called search Term. Provides a way to look for something in our database. Returns a view.
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        public IActionResult SearchResults(string searchTerm)
        {
            ProductsDAO products = new ProductsDAO(); // Gets access to the database via instance.

            List<ProductModel> productList = products.SearchProducts(searchTerm);
            return View("index", productList);
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
