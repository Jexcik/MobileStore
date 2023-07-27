using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using System.Diagnostics;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsRepository productsRepository;

        public HomeController()
        {
            productsRepository = new ProductsRepository();
        }

        public IActionResult Index()
        {
            var products = productsRepository.GetAll();
            return View(products);
        }
    }
}