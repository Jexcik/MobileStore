﻿using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class AdministratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetOrders()
        {
            return View();
        }
        public IActionResult GetProducts() 
        {
            return View();
        }
        public IActionResult GetUsers()
        {
            return View();
        }
        public IActionResult GetRoles() 
        {
            return View();
        }
    }
}