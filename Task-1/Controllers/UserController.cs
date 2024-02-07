using Microsoft.AspNetCore.Mvc;
using Task_1.Models;

namespace Task_1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult ListOfProducts()
        {

          
            return View();
        }
    }
}
