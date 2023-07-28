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
            var cart = CartsRepository.TruGetByUserId(Constants.UserId);
            return View(cart);
        }
        public IActionResult Add(int productId)
        {
            var product = productsRepository.TryGetById(productId);
            CartsRepository.Add(product,Constants.UserId);
            return RedirectToAction("Index");
        }
        public IActionResult DecreaseAmount(int productId)
        {
            CartsRepository.DecreaseAmount(productId, Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
