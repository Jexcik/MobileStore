using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly IProductsRepository productsRepository;

        public AdministratorController(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }
        public IActionResult GetOrders()
        {
            return View();
        }
        public IActionResult GetProducts() 
        {
            var products = productsRepository.GetAll();
            return View(products);
        }
        public IActionResult GetUsers()
        {
            return View();
        }
        public IActionResult GetRoles() 
        {
            return View();
        }
        public IActionResult AddProduct()
        {
            return View();
        }
    }
}
