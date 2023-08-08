using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class AutorizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Enter(Login login)
        {
            return Redirect("~/Home/Index");
        }
        public IActionResult Register(Login login) 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewUser(Login login) 
        {
            return Redirect("~/Home/Index");
        }
    }
}
