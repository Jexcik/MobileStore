using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartsRepository cartsRepository;
        private readonly Constants constants;

        public OrderController(ICartsRepository cartsRepository, Constants constants)
        {
            this.cartsRepository = cartsRepository;
            this.constants = constants;
        }

        public IActionResult Index()
        {
            var cart = cartsRepository.TryGetByUserId(constants.UserId);
            return View(cart);
        }
    }
}
