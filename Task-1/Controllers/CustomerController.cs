using Microsoft.AspNetCore.Mvc;
using Task_1.Models;

namespace Task_1.Controllers
{
    public class CustomerController : Controller
    {
        List<Product> products = new List<Product>();
        public CustomerController()
        {
            products = ProductsDetails();


        }

        public List<Product> ProductsDetails()
        {
            products.Add(new Product { Id = 1, Name = "Apple", Description = "Phone", Price = 80000 });
            products.Add(new Product { Id = 2, Name = "Hp", Description = "Laptop", Price = 50000 });
            products.Add(new Product { Id = 3, Name = "LG", Description = "Tv", Price = 40000 });
            products.Add(new Product { Id = 4, Name = "Dell", Description = "Laptop", Price = 70000 });

            return products;
        }
        public JsonResult ListOfProducts()
        {

            var data = products;
            return Json(data);
        }

        public IActionResult ListOfProductsDetails()
        {
            var data = products;
            return View(data);
        }
    }
}
