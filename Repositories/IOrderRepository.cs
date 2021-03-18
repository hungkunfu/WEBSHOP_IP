using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Entities;
using WebShopIP.Models.ViewModels;

namespace WebShopIP.Repositories
{
    public interface IOrderRepository
    {
        public int CreateOrder(Order order);

        public List<Order> GetOrderList();

        public int DeleteOrder(int id);

        public Order GetOrder(int id);

        public int UpdateOrder(Order order);

        public ConfirmPayView GetConfirmInfo(int id);

        public double GetTotalInAOrder(Order order);

        public int PayOrder(int id);

        public int AddOrderDetailInOrder(Order order, int productId, int amount);

        public List<OrderDetail> GetOrderDetailsByOrderId(int id);

        public List<Order> GetOrdersByUserId(string id);
    }
}
