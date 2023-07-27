using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductsRepository productsRepository;

        public CartController()
        {
            productsRepository = new ProductsRepository();
        }

        public IActionResult Index()
        {
            var cart = CartsRepository.TruGetByUserId(Constants.UseId);
            return View(cart);
        }
        public IActionResult Add(int productId)
        {
            var product = productsRepository.TryGetById(productId);
            CartsRepository.Add(product,Constants.UseId);
            return RedirectToAction("Index");
        }
    }
}
