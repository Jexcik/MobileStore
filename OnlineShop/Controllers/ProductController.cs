using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductsInMemoryRepository productsRepository;

        public ProductController(ProductsInMemoryRepository productsRepository)
        {
            this.productsRepository = new ProductsInMemoryRepository();
        }

        public IActionResult Index(int id)
        {
            var product = productsRepository.TryGetById(id);
            return View(product);
        }
    }
}
