using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebShopIP.Models;
using WebShopIP.Models.Product;
using WebShopIP.Models.ProductPagination;
using WebShopIP.Models.ViewModels;
using WebShopIP.Repositories;
using WebShopIP.Services;

namespace WebShopIP.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IProductService productService;
        public const string CartKey = "Cart";
        public ProductController(IProductRepository productRepository,
            IProductService productService)
        {
            this.productService = productService;
            this.productRepository = productRepository;
        }
        public IActionResult Index(int? pageNumber, int? pageSize, string keyword)
        {
            var employees = productRepository.Gets(keyword).OrderByDescending(e => e.Id).ToList();
            var pagination = new Pagination(employees.Count, pageNumber, pageSize, keyword);
            var viewModel = new PaginationProduct()
            {
                products = employees.Skip((pagination.CurrentPage - 1) * pagination.PageSize).Take(pagination.PageSize).ToList(),
                Pagination = pagination
            };
            return View(viewModel);
        
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CreateProductView productView)
        {
            if (ModelState.IsValid)
            {
                int result = productRepository.CreateProduct(productView);
                if (result == -1)
                {
                    ModelState.AddModelError("", "Tên Sản Phẩm Đả Tồn Tại");
                    return View(productView);
                }

                if (result > 0)
                    return RedirectToAction("Index", "Product");

                ModelState.AddModelError("", "Error");
            }
            return View();
        }
        [HttpGet]
        [Route("/Product/Delete/{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            var result = productRepository.DeleteProduct(id);
            return Json(new { result });
        }

        [HttpGet]
        public IActionResult Edit(int id) => View(productRepository.FindProductToView(id));

        [HttpPost]
        public IActionResult Edit(EditProductView productView)
        {
            if (productView.Price <= 0)
            {
                ModelState.AddModelError("", "Số tiền không hợp lệ");
                return View(productView);
            }
            if (ModelState.IsValid)
            {
                if (productRepository.UpdateProduct(productView) > 0)
                    return RedirectToAction("Index", "Product");
            }
            return View(productView);
        }

        [HttpGet]
        public IActionResult Restore() => View(productRepository.GetInActiveProducts());

        [HttpPost]
        public IActionResult Restore(List<ReStoreView> ReStoreViews)
        {
            int result = productRepository.RestoreProducts(ReStoreViews);

            if (result > 0 || result == 0)
                return RedirectToAction("Index", "Product");

            ModelState.AddModelError("", "Error");
            return View(ReStoreViews);
        }
        //public IActionResult Index()
        //{
        //    GetCookies();
        //    var products = productService.Gets().OrderByDescending(e => e.ProductId).ToList();
        //    var pagination = new Pagination(products.Count, 1, 10, null);
        //    var viewModel = new ProductView()
        //    {
        //        Products = products.Skip((pagination.CurrentPage - 1) * pagination.PageSize).Take(pagination.PageSize).ToList(),
        //        Pagination = pagination
        //    };
        //    return View(viewModel);
        //}
        public IActionResult NewIndex(int? pageNumber, int? pageSize, string keyword)
        {
            var employees = productRepository.Gets(keyword).OrderByDescending(e => e.Id).ToList();
            var pagination = new Pagination(employees.Count, pageNumber, pageSize, keyword);
            var viewModel = new PaginationProduct()
            {
                products = employees.Skip((pagination.CurrentPage - 1) * pagination.PageSize).Take(pagination.PageSize).ToList(),
                Pagination = pagination
            };
            return View(viewModel);

        }
        [Route("/Product/{productId:int}")]
        public IActionResult AddToCard([FromRoute] int productId)
        {
            var product = productService.Get(productId);
            if (product == null)
            {
                return NotFound("Product is not foud");
            }

            var cart = GetCartItems();
            var existingItem = cart.Find(c => c.Product.Id == productId);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                cart.Add(new Cart()
                {
                    Quantity = 1,
                    Product = product
                });
            }
            SaveCart(cart);
            return RedirectToAction("index");
        }

        [Route("/Product/Cart", Name = "cart")]
        public IActionResult Cart()
        {
            GetCookies();
            return View(GetCartItems());
        }

        [Route("/Product/UpdateCart", Name = "updatecart")]
        public IActionResult UpdateCart([FromForm] int productid, [FromForm] int quantity)
        {
            var session = HttpContext.Session;
            var jsonCart = session.GetString(CartKey);
            if (!string.IsNullOrEmpty(jsonCart))
            {
                var carts = JsonConvert.DeserializeObject<List<Cart>>(jsonCart);
                var cartItem = carts.FirstOrDefault(e => e.Product.Id == productid);
                cartItem.Quantity = quantity;
                SaveCart(carts);
            }
            return Ok();
        }

        [Route("/Product/RemoveCartItem/{productId}")]
        public IActionResult RemoveCartItem([FromRoute] int productId)
        {
            var session = HttpContext.Session;
            var jsonCart = session.GetString(CartKey);
            if (!string.IsNullOrEmpty(jsonCart))
            {
                var carts = JsonConvert.DeserializeObject<List<Cart>>(jsonCart);
                var cartItem = carts.FirstOrDefault(e => e.Product.Id == productId);
                carts.Remove(cartItem);
                SaveCart(carts);
            }
            return Ok();
        }
        private List<Cart> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsonCart = session.GetString(CartKey);
            if (!string.IsNullOrEmpty(jsonCart))
            {
                return JsonConvert.DeserializeObject<List<Cart>>(jsonCart);
            }
            return new List<Cart>();
        }
        //private void ClearCart()
        //{
        //    var session = HttpContext.Session;
        //    session.Remove(CartKey);
        //}

        private void SaveCart(List<Cart> cart)
        {
            var session = HttpContext.Session;
            var jsonCart = JsonConvert.SerializeObject(cart);
            session.SetString(CartKey, jsonCart);
            SetCookie(jsonCart);
        }

        private void GetCookies()
        {
            var cart_cookie = Request.Cookies["carts"];
            if (!string.IsNullOrEmpty(cart_cookie))
            {
                var cart = JsonConvert.DeserializeObject<List<Cart>>(cart_cookie);
                SaveCart(cart);
            }
        }
        private void SetCookie(string joinCart)
        {
            Response.Cookies.Append("carts", joinCart);
        }
    }
}
