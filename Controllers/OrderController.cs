using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShopIP.Entities;
using WebShopIP.Repositories;

namespace WebShopIP.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public IActionResult Index()
        {
            return View(orderRepository.GetOrderList());
        }


        [Route("/Order/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = orderRepository.DeleteOrder(id);
            return Json(new { result });
        }

        [HttpGet]
        public IActionResult Edit(int id) => View(orderRepository.GetOrder(id));

        [HttpPost]
        public IActionResult Edit(Order order)
        {
            if (orderRepository.UpdateOrder(order) > 0)
                return RedirectToAction("Index", "Order");

            ModelState.AddModelError("", "Error");

            return View(order);
        }

        [Route("/Order/ConfirmPay/{id}")]
        public IActionResult ConfirmPay(int id)
        {
            List<string> result = new List<string>();
            var confirmm = orderRepository.GetConfirmInfo(id);

            result.Add(confirmm.NameCustomer);
            result.Add(confirmm.CreateAt);
            result.Add(confirmm.ShipDate);
            result.Add(confirmm.Total.ToString());

            return Json(new { result });
        }


        [Route("/Order/Pay/{id}")]
        public IActionResult Pay(int id)
        {
            var result = orderRepository.PayOrder(id);
            return Json(new { result });
        }

        [HttpGet]
        public IActionResult WatchHistoryByUserId(string id) => View(orderRepository.GetOrdersByUserId(id));
    }
}

