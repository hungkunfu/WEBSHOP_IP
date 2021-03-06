using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShopIP.Entities;
using WebShopIP.Models.CartSession;
using WebShopIP.Repositories;

namespace WebShopIP.Controllers
{
    public class CartController : Controller
    {
        public CartController(IOrderRepository orderRepository,
             ICustomerInfoRepository infoRepository)
        {
            this.orderRepository = orderRepository;
            this.infoRepository = infoRepository;
        }
        private const string CartSession = "CartSession";
        private readonly IOrderRepository orderRepository;
        private readonly ICustomerInfoRepository infoRepository;

        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);
            HttpContext.Session.SetObjectAsJson(CartSession, cart);

            Response.Cookies.Append("ProductLike", "1");

            return View(cart);
        }
        [HttpGet]
        [Route("/Cart/AddItem/{id}/{amount}")]
        public IActionResult AddItem(int id, int amount)
        {
            CartItem item = new CartItem() { ProductId = id, Amount = amount };
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);

            string ck = Request.Cookies["ProductLike"];
            if (ck != null)
            {
                string result = Request.Cookies["ProductLike"];
                Response.Cookies.Append("ProductLike", result + $";{id}");
                result = Request.Cookies["ProductLike"];
                int[] ia = result.Split(';').Select(n => Convert.ToInt32(n)).ToArray();
                string[] strarr = { "1", "2" };
                string str = String.Join(";", strarr);
                Response.Cookies.Append("cookies", str);
                ViewData["cookies"] = Request.Cookies["cookies"];
            }
            else
            {
                Response.Cookies.Append("ProductLike", id.ToString());
            }
            ViewData["ProductLike"] = Request.Cookies["ProductLike"];

            if (cart.Count != 0)
            {
                if (cart.Exists(el => el.ProductId == item.ProductId))
                {
                    cart.FirstOrDefault(el => el.ProductId == item.ProductId).Amount += amount;
                    HttpContext.Session.SetObjectAsJson(CartSession, cart);
                    return Json(-1);
                }
                cart.Add(item);
                HttpContext.Session.SetObjectAsJson(CartSession, cart);

                return Json(cart.Count);
            }
            cart.Add(item);
            HttpContext.Session.SetObjectAsJson(CartSession, cart);

            return Json(cart.Count);
        }

        [Route("/Cart/OrderByAccount/{id}")]
        public IActionResult OrderByAccount(string id)
        {
            var order = new Order()
            {
                CreateBy = id,
                CreateAt = DateTime.Today,
                ShipperDate = DateTime.Today.AddDays(3)
            };
            orderRepository.CreateOrder(order);
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);

            foreach (var item in cart)
                orderRepository.AddOrderDetailInOrder(order, item.ProductId, item.Amount);

            int result = orderRepository.GetOrderDetailsByOrderId(order.Id).Count;
            if (result > 0)
                HttpContext.Session.SetObjectAsJson(CartSession, new List<CartItem>());

            return Json(result);
        }

        [Route("/Cart/RemoveItem/{id}")]
        public IActionResult RemoveItem(int id)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);
            int lengthCartBefor = cart.Count;

            CartItem item = cart.Find(el => el.ProductId == id);
            cart.Remove(item);

            HttpContext.Session.SetObjectAsJson(CartSession, cart);

            return Json(lengthCartBefor - cart.Count);
        }
        [HttpGet]
        [Route("/Cart/OrderWithoutAccount/{name}/{phoneNum}/{email}/{address}")]
        public IActionResult OrderWithoutAccount(string name, string phoneNum, string email, string address)
        {
            int result = 0;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(address) && phoneNum.Length > 8)
            {
                if (email.Contains("@") == false)
                    return Json(result);

                InfoCustomer infoCustomer = new InfoCustomer()
                {
                    Name = name,
                    PhoneNum = phoneNum,
                    Email = email,
                    Address = address
                };
                int createInfoResult = infoRepository.CreateInfoCustomer(infoCustomer);

                if (createInfoResult > 0)
                {
                    var order = new Order()
                    {
                        CreateAt = DateTime.Today,
                        ShipperDate = DateTime.Today.AddDays(3),
                        InfoCustomerId = infoCustomer.Id
                    };
                    orderRepository.CreateOrder(order);

                    var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);
                    foreach (var item in cart)
                        orderRepository.AddOrderDetailInOrder(order, item.ProductId, item.Amount);

                    result = orderRepository.GetOrderDetailsByOrderId(order.Id).Count;
                    if (result > 0)
                        HttpContext.Session.SetObjectAsJson(CartSession, new List<CartItem>());
                }
            }
            return Json(result);
        }
        //[Route("/updatecart", Name = "updatecart")]
        //[HttpPost]
        //public IActionResult UpdateCart([FromForm]int productId, [FromForm]int quantity) 
        //{
        //    return RedirectToAction(nameof(CartItem));
        //}
    }
}
