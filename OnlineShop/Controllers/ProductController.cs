using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly InMemoryProductsRepository productsRepository;

        public ProductController(InMemoryProductsRepository productsRepository)
        {
            this.productsRepository = new InMemoryProductsRepository();
        }

        public IActionResult Index(int id)
        {
            var product = productsRepository.TryGetById(id);
            return View(product);
        }
    }
}
