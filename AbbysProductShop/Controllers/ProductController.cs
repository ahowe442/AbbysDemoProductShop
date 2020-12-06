using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbbysProductShop.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AbbysProductShop.Controllers
{
    public class ProductController : Controller
    {
        //Returns a single searched product
        // GET: /<controller>/
        public IActionResult Detail(string slugLink)
        {
            Product product = DataBase.GetProduct(slugLink);
            return View(product);
        }
        //Returns all products in a list. 
        public IActionResult List()
        {
            List<Product> products = DataBase.GetProducts();
            return View(products);
        }
    }
}
