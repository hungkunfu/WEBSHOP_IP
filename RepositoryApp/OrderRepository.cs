using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Dbcontexts;
using WebShopIP.Entities;
using WebShopIP.Models;
using WebShopIP.Models.ViewModels;
using WebShopIP.Repositories;

namespace WebShopIP.RepositoryApp
{
    public class OrderRepository: IOrderRepository
    {
        private readonly AppDbContexts context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IOrderDetailRepository detailRepository;

        public OrderRepository(AppDbContexts context, UserManager<ApplicationUser> userManager,
            IOrderDetailRepository detailRepository)
        {
            this.context = context;
            this.userManager = userManager;
            this.detailRepository = detailRepository;
        }
        public int CreateOrder(Order order)
        {
            context.Add(order);
            return (context.SaveChanges());
        }

        public int AddOrderDetailInOrder(Order order, int productId, int amount)
        {
            Product product = context.Products.FirstOrDefault(el => el.Id == productId);

            if (context.Orders.ToList().Contains(order) && product != null)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    OrderId = order.Id,
                    ProductId = product.Id,
                    Quantity = amount,
                    UnitPrice = product.PricePerUnit * amount
                };
                context.Add(orderDetail);

                product.SaleCount += amount;
                context.Update(product);
            }
            //return (context.SaveChanges());
            return context.SaveChanges();
        }

        public int DeleteOrder(int id)
        {
            var order = context.Orders.FirstOrDefault(el => el.Id == id);

            if (order == null)
                return -1;
            context.Remove(order);

            return context.SaveChanges();
        }

        public ConfirmPayView GetConfirmInfo(int id)
        {
            Order order = context.Orders.FirstOrDefault(el => el.Id == id);

            ConfirmPayView confirmPay = new ConfirmPayView()
            {
                NameCustomer = userManager.FindByIdAsync(order.CreateBy).Result.FirstName,
                CreateAt = order.CreateAt.ToString(),
                ShipDate = order.ShipperDate.ToString(),
                Total = GetTotalInAOrder(order)
            };
            return confirmPay;
        }

        public Order GetOrder(int id) => context.Orders.FirstOrDefault(el => el.Id == id);

        public List<Order> GetOrderList() => context.Orders.ToList().FindAll(el => el.PayStatus == Enum.PayStatus.unpaid);

        public double GetTotalInAOrder(Order order)
        {
            var orderDetails = context.OrderDetails.ToList().FindAll(el => el.OrderId == order.Id);

            double total = new double();
            foreach (var item in orderDetails)
            {
                var product = context.Products.FirstOrDefault(el => el.Id == item.ProductId);
                total += detailRepository.CalculateMoney(product.PricePerUnit, item.Discount, item.Quantity);
            }
            return total;
        }

        public int PayOrder(int id)
        {
            var order = context.Orders.FirstOrDefault(el => el.Id == id);
            order.PayStatus = Enum.PayStatus.Paid;
            context.Update(order);

            return Task.Run(async () => await context.SaveChangesAsync()).Result;
        }

        public int UpdateOrder(Order order)
        {
            context.Update(order);
            return context.SaveChanges();
        }

        public List<OrderDetail> GetOrderDetailsByOrderId(int id) =>
            context.OrderDetails.ToList().FindAll(el => el.OrderId == id);

        public List<Order> GetOrdersByUserId(string id) => context.Orders.Where(el => el.CreateBy == id).ToList();
    }
}