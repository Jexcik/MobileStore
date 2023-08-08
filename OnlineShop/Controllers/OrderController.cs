﻿using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartsRepository cartsRepository;
        private readonly IOrdersRepository ordersRepository;
        private readonly Constants constants;

        public OrderController(ICartsRepository cartsRepository,IOrdersRepository ordersRepository, Constants constants)
        {
            this.cartsRepository = cartsRepository;
            this.ordersRepository = ordersRepository;
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
            order.Cart=cartsRepository.TryGetByUserId(constants.UserId);
            ordersRepository.Add(order);
            cartsRepository.Clear();
            return View(order);
        }
    }
}
