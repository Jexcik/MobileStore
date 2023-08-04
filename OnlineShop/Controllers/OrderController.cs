using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;

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

        //Возвращает данные из представления на сервер
        [HttpPost]
        public IActionResult Buy(Order order)
        {
            cartsRepository.Clear();
            return View();
        }
    }
}
