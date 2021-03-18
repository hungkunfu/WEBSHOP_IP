using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Models.CartSession;
using WebShopIP.Repositories;

namespace WebShopIP.Controllers
{
    public class CustomerHomeController:Controller
    {
        private const string CartSession = "CartSession";
        private readonly ICategoryRepository categoryRepository;

        public CustomerHomeController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("CartSession");

            if (cart == null)
                HttpContext.Session.SetObjectAsJson("CartSession", new List<CartItem>());
            else
                HttpContext.Session.SetObjectAsJson("CartSession", cart);

            return View(categoryRepository.Categories);
        }

        [HttpGet]
        public IActionResult WatchProducts(int id) => View(categoryRepository.GetProductsByCategoryId(id));

        public IActionResult WatchCart()
        {
            string[] strarr = { "1", "2" };
            string str = String.Join(" ", strarr);
            Response.Cookies.Append("cookies", str);
            ViewData["cookies"] = Request.Cookies["cookies"];
            var a = ViewData["cookies"];

            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);

            if (cart != null)
                HttpContext.Session.SetObjectAsJson(CartSession, cart);
            else
                HttpContext.Session.SetObjectAsJson(CartSession, new List<CartItem>());

            return View(cart);
        }
    }
}
