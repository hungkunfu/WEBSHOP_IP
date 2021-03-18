using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShopIP.Repositories;

namespace WebShopIP.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerInfoRepository customerInfoRepository;

        public CustomerController(ICustomerInfoRepository customerInfoRepository)
        {
            this.customerInfoRepository = customerInfoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomerDetails(int id) => View(customerInfoRepository.GetInfoCustomerById(id));
    }
}
