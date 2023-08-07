using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using System.Diagnostics;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsRepository productsRepository;
        private readonly ICartsRepository cartsRepository;
        private readonly Constants constants;

        public HomeController(IProductsRepository productsRepository, ICartsRepository cartsRepository, Constants constants)
        {
            this.productsRepository = productsRepository;
            this.cartsRepository = cartsRepository;
            this.constants = constants;
        }

        public IActionResult Index()
        {
            var products = productsRepository.GetAll();
            return View(products);
        }
    }
}