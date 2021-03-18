using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebShopIP.Entities;
using WebShopIP.Models;
using Microsoft.AspNetCore.Authorization;
using WebShopIP.Models.CartSession;
using WebShopIP.Repositories;

namespace WebShopIP.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository homeRepository;

        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _logger = logger;
            this.homeRepository = homeRepository;
        }
        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("CartSession");

            if (cart == null)
                HttpContext.Session.SetObjectAsJson("CartSession", new List<CartItem>());
            else
                HttpContext.Session.SetObjectAsJson("CartSession", cart);

            return View(homeRepository.Categories);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult WatchProduct(int id) => View(homeRepository.GetProductsByCateId(id));


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
